using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace AgriTrack.Admin_Forms
{
    public partial class Daily_Harvest : Form
    {

        private string connectionString = "Data Source=" + System.IO.Path.Combine(Application.StartupPath, "AgriTrackDB.db") + ";";

        public Daily_Harvest()
        {
            InitializeComponent();


            this.Load += Daily_Harvest_Load;
            this.btnLoadReport.Click += btnLoadReport_Click;
        }


        private void Daily_Harvest_Load(object sender, EventArgs e)
        {

            dateTimePicker1.Value = DateTime.Today;


            LoadHarvestData(DateTime.Today);
        }


        private void btnLoadReport_Click(object sender, EventArgs e)
        {

            LoadHarvestData(dateTimePicker1.Value.Date);
        }


        private void LoadHarvestData(DateTime selectedDate)
        {

            dataGridView1.Rows.Clear();
            double totalHarvest = 0;


            string dateString = selectedDate.ToString("yyyy-MM-dd");


            string query = @"
                SELECT 
                    h.WorkerID, 
                    w.Name AS WorkerName, 
                    h.TeaKg AS HarvestKg, 
                    a.Status 
                FROM Harvest h
                INNER JOIN Worker w ON h.WorkerID = w.WorkerID
                LEFT JOIN Attendance a ON h.WorkerID = a.WorkerID AND a.AttendanceDate = h.HarvestDate
                WHERE h.HarvestDate = @SelectedDate";

            try
            {

                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {

                        cmd.Parameters.AddWithValue("@SelectedDate", dateString);

                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {

                                string workerId = reader["WorkerID"].ToString();
                                string workerName = reader["WorkerName"].ToString();
                                double harvestKg = Convert.ToDouble(reader["HarvestKg"]);


                                string status = reader["Status"] != DBNull.Value ? reader["Status"].ToString() : "-";


                                dataGridView1.Rows.Add(workerId, workerName, harvestKg, status);


                                totalHarvest += harvestKg;
                            }
                        }
                    }
                }


                textBox1.Text = totalHarvest.ToString("0.00") + " Kg";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading harvest report: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            dashboard1 dashboard = new dashboard1();
            dashboard.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            add_farmmer_1 add_farmer_1 = new add_farmmer_1();
            add_farmer_1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Advance_Settlement adminAdv = new Advance_Settlement();
            adminAdv.Show();
            this.Hide();
        }

        private void Settlment_Click(object sender, EventArgs e)
        {
            Advance_Settlement settlement_UI = new Advance_Settlement(); settlement_UI.Show();this.Hide();
        }
    }
}