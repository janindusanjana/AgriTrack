using System;
using System.Data;
using Microsoft.Data.Sqlite;
using System.Windows.Forms;
using AgriTrack.Admin_Forms;

namespace AgriTrack
{
    public partial class add_farmmer_1 : Form
    {

        private readonly string connectionString = "Data Source=" + System.IO.Path.Combine(Application.StartupPath, "AgriTrackDB.db") + ";";

        public add_farmmer_1()
        {
            InitializeComponent();
            InitializeClock();

        

            btnSearch.Click += btnSearch_Click;
            dgvWorkers.CellContentClick += dgvWorkers_CellContentClick;
            btnClear.Click += btnClear_Click;
            btnDashBoard.Click += btnDashBoard_Click;
            button3.Click += button3_Click; 
            button4.Click += button4_Click;  
            Settlment.Click += Settlment_Click; 
            btnAddWorker.Click += btnAddWorker_Click;

            LoadAllWorkersData();
        }


        private void InitializeClock()
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += (s, e) => { lblClock.Text = DateTime.Now.ToString("h:mm:ss tt"); };
            timer.Start();
        }


        private void btnClear_Click(object? sender, EventArgs e)
        {

            txtWorkerID.Clear();


            LoadAllWorkersData();
        }


        private void btnSearch_Click(object? sender, EventArgs e)
        {
            string workerId = txtWorkerID.Text.Trim();

            if (string.IsNullOrEmpty(workerId))
            {
                LoadAllWorkersData();
            }
            else
            {
                LoadWorkerData(workerId);
            }
        }


        private void LoadAllWorkersData()
        {
            dgvWorkers.Rows.Clear();

            using (SqliteConnection con = new SqliteConnection(connectionString))
            {
                string query = @"
                    SELECT w.WorkerID, w.Name, w.Gender, a.check_in, a.check_out 
                    FROM Worker w
                    LEFT JOIN Attendance a ON w.WorkerID = a.WorkerID AND a.AttendanceDate = @Today";

                using (SqliteCommand cmd = new SqliteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Today", DateTime.Today.ToString("yyyy-MM-dd"));

                    try
                    {
                        con.Open();
                        using (SqliteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string id = reader["WorkerID"]?.ToString() ?? string.Empty;
                                string name = reader["Name"]?.ToString() ?? string.Empty;
                                string gender = reader["Gender"]?.ToString() ?? string.Empty;

                                string checkIn = reader["check_in"]?.ToString() ?? string.Empty;
                                string checkOut = reader["check_out"]?.ToString() ?? string.Empty;

                                bool isPresent = !string.IsNullOrEmpty(checkIn) && string.IsNullOrEmpty(checkOut);

                                dgvWorkers.Rows.Add(id, name, gender, checkIn, checkOut, isPresent);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Database connection error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void LoadWorkerData(string workerId)
        {
            dgvWorkers.Rows.Clear();

            using (SqliteConnection con = new SqliteConnection(connectionString))
            {
                string query = @"
                    SELECT w.WorkerID, w.Name, w.Gender, a.check_in, a.check_out 
                    FROM Worker w
                    LEFT JOIN Attendance a ON w.WorkerID = a.WorkerID AND a.AttendanceDate = @Today
                    WHERE w.WorkerID = @WorkerID";

                using (SqliteCommand cmd = new SqliteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Today", DateTime.Today.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@WorkerID", workerId);

                    try
                    {
                        con.Open();
                        using (SqliteDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string name = reader["Name"]?.ToString() ?? string.Empty;
                                string gender = reader["Gender"]?.ToString() ?? string.Empty;

                                string checkIn = reader["check_in"]?.ToString() ?? string.Empty;
                                string checkOut = reader["check_out"]?.ToString() ?? string.Empty;

                                bool isPresent = !string.IsNullOrEmpty(checkIn) && string.IsNullOrEmpty(checkOut);

                                dgvWorkers.Rows.Add(workerId, name, gender, checkIn, checkOut, isPresent);
                            }
                            else
                            {
                                MessageBox.Show("Worker ID not found in the registry.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadAllWorkersData();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Database connection error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void dgvWorkers_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5 && e.RowIndex >= 0)
            {
                dgvWorkers.CommitEdit(DataGridViewDataErrorContexts.Commit);

                var isPresentValue = dgvWorkers.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                bool isChecked = isPresentValue != null && (bool)isPresentValue;

                var workerIdObj = dgvWorkers.Rows[e.RowIndex].Cells["colWorkerID"].Value;
                string workerId = workerIdObj?.ToString() ?? string.Empty;

                if (string.IsNullOrEmpty(workerId)) return;

                string currentTime = DateTime.Now.ToString("HH:mm:ss");

                if (isChecked)
                {
                    dgvWorkers.Rows[e.RowIndex].Cells["colCheckIn"].Value = currentTime;
                    SaveAttendanceToDatabase(workerId, currentTime, isCheckIn: true);
                }
                else
                {
                    dgvWorkers.Rows[e.RowIndex].Cells["colCheckOut"].Value = currentTime;
                    SaveAttendanceToDatabase(workerId, currentTime, isCheckIn: false);
                }
            }
        }


        private void SaveAttendanceToDatabase(string workerId, string time, bool isCheckIn)
        {
            using (SqliteConnection con = new SqliteConnection(connectionString))
            {
                string query = "";

                if (isCheckIn)
                {
                    query = @"
                        INSERT INTO Attendance (WorkerID, AttendanceDate, check_in, Status) 
                        SELECT @WorkerID, @Date, @Time, 'Present'
                        WHERE NOT EXISTS (
                            SELECT 1 FROM Attendance WHERE WorkerID = @WorkerID AND AttendanceDate = @Date
                        )";
                }
                else
                {
                    query = @"
                        UPDATE Attendance 
                        SET check_out = @Time 
                        WHERE WorkerID = @WorkerID AND AttendanceDate = @Date AND check_out IS NULL";
                }

                using (SqliteCommand cmd = new SqliteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@WorkerID", workerId);
                    cmd.Parameters.AddWithValue("@Date", DateTime.Today.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@Time", time);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to save attendance: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (Userdata.Role == "Admin")
            {
                
                Daily_Harvest adminSet = new Daily_Harvest();
                adminSet.Show();
                this.Hide();
            }
            else if (Userdata.Role == "User")
            {
                DailyHarvestAdding daily = new DailyHarvestAdding();
            daily.Show();

            this.Hide();
        }

        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (Userdata.Role == "Admin")
            {

                Advance_Settlement adminSet = new Advance_Settlement();
                adminSet.Show();
                this.Hide();
            }
            else if (Userdata.Role == "User")
            {
                Advance advanced = new Advance();
            advanced.Show();

            this.Hide();
        }

        }
        private void Settlment_Click(object sender, EventArgs e)
        {
            if (Userdata.Role == "Admin")
            {

                Advance_Settlement adminSet = new Advance_Settlement();
                adminSet.Show();
                this.Hide();
            }
            else if (Userdata.Role == "User")
            {
                Settlement_UI settlement_UI = new Settlement_UI();

                settlement_UI.Show();

                this.Hide();
            }
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            dashboard1 dashboard1 = new dashboard1();
            dashboard1.Show();

            this.Hide();
        }

        private void btnAddWorker_Click(object sender, EventArgs e)
        {
            farmmer_add_form add1=new farmmer_add_form();
            add1.Show();
            this.Show();
        }
    }
}