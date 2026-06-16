using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace AgriTrack
{
    public partial class Advance : Form
    {
        private string connectionString = "Data Source=AgriTrackDB.db;Version=3;";

        public Advance()
        {
            InitializeComponent();
        }

        private void btnSaveAdvance_Click(object sender, EventArgs e)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string insertQuery = "INSERT INTO Advance (WorkerID, Amount, AdvanceDate) VALUES (@WorkerID, @Amount, @AdvanceDate)";
                using (var cmd = new SQLiteCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@WorkerID", txtWorkerID.Text);
                    cmd.Parameters.AddWithValue("@Amount", numAdvanceAmount.Value);
                    cmd.Parameters.AddWithValue("@AdvanceDate", dtpAdvanceDate.Value.Date);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Advance saved successfully.");
            btnSearchWorker.PerformClick();
        }

        private void btnClearAdvance_Click(object sender, EventArgs e)
        {
            txtWorkerID.Clear();
            txtWorkerName.Clear();
            txtWorkerNIC.Clear();
            txtWorkerPhone.Clear();
            numAdvanceAmount.Value = 0;
            lblOutstandingAdvance.Text = "";
            dgvAdvanceHistory.DataSource = null;
        }

        private void btnCancelAdvance_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearchWorker_Click(object sender, EventArgs e)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();


                string query = "SELECT Name, NIC, Phone FROM Worker WHERE WorkerID=@WorkerID";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@WorkerID", txtWorkerID.Text);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtWorkerName.Text = reader["Name"].ToString();
                            txtWorkerNIC.Text = reader["NIC"].ToString();
                            txtWorkerPhone.Text = reader["Phone"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Worker not found.");
                            return;
                        }
                    }
                }


                string sumQuery = "SELECT IFNULL(SUM(Amount),0) FROM Advance WHERE WorkerID=@WorkerID";
                using (var cmd = new SQLiteCommand(sumQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@WorkerID", txtWorkerID.Text);
                    lblOutstandingAdvance.Text = cmd.ExecuteScalar().ToString();
                }


                string historyQuery = "SELECT AdvanceID, Amount, AdvanceDate FROM Advance WHERE WorkerID=@WorkerID";
                using (var da = new SQLiteDataAdapter(historyQuery, conn))
                {
                    da.SelectCommand.Parameters.AddWithValue("@WorkerID", txtWorkerID.Text);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvAdvanceHistory.DataSource = dt;
                }
            }
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            dashboard1 dashboard = new dashboard1();
            dashboard.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            add_farmmer_1 add_farmer_1 = new add_farmmer_1();
            add_farmer_1.Show();

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DailyHarvestAdding dailyHarvestAdding = new DailyHarvestAdding();
            dailyHarvestAdding.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Advance advance = new Advance();
            advance.Show();

            this.Hide();
        }

        private void Settlment_Click(object sender, EventArgs e)
        {
            Settlement_UI settlement_UI = new Settlement_UI();
            settlement_UI.Show();

            this.Hide();
        }
    }
}
