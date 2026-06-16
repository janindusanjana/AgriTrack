using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace AgriTrack
{
    public partial class DailyHarvestAdding : Form
    {

        private string connectionString = "data source=C:\\Users\\wwwja\\Desktop\\AgriTrack\\AgriTrackDB.db";

        public DailyHarvestAdding()
        {
            InitializeComponent();


            btnSave.Click += btnSave_Click;
            btnClear.Click += btnClear_Click;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtWageRate.Text = "";
            txtTotalHarvest.Text = "";
            txtWorkerId.Text = "";
            txtWorkerName.Text = "";
            numPluckedKg.Value = 0;
            dtpDate.Value = DateTime.Today;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!long.TryParse(txtWorkerId.Text.Trim(), out long workerId))
            {
                MessageBox.Show("Invalid Worker Id");
                return;
            }
            if (!decimal.TryParse(txtWageRate.Text.Trim(), out decimal wageRate) || wageRate <= 0)
            {
                MessageBox.Show("Invalid wage rate");
                return;
            }
            decimal pluckedKg = numPluckedKg.Value;
            if (pluckedKg <= 0)
            {
                MessageBox.Show("Plucked kilos must be > 0");
                return;
            }

            DateTime harvestDate = dtpDate.Value.Date;

            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (var tx = conn.BeginTransaction())
                {
                    try
                    {

                        string insertHarvest = @"
INSERT INTO Harvest (WorkerID, HarvestDate, TeaKg, Timestamp)
VALUES (@wid, @hdate, @kg, @ts);";
                        using (var cmd = new SqlCommand(insertHarvest, conn, tx))
                        {
                            cmd.Parameters.AddWithValue("@wid", workerId);
                            cmd.Parameters.AddWithValue("@hdate", harvestDate);
                            cmd.Parameters.AddWithValue("@kg", pluckedKg);
                            cmd.Parameters.AddWithValue("@ts", DateTime.Now);
                            cmd.ExecuteNonQuery();
                        }


                        int year = harvestDate.Year, month = harvestDate.Month;
                        DateTime monthStart = new DateTime(year, month, 1);


                        string sumKgSql = @"
SELECT ISNULL(SUM(TeaKg),0) FROM Harvest
WHERE WorkerID=@wid AND YEAR(HarvestDate)=@y AND MONTH(HarvestDate)=@m";
                        decimal totalKg = 0;
                        using (var cmd = new SqlCommand(sumKgSql, conn, tx))
                        {
                            cmd.Parameters.AddWithValue("@wid", workerId);
                            cmd.Parameters.AddWithValue("@y", year);
                            cmd.Parameters.AddWithValue("@m", month);
                            totalKg = Convert.ToDecimal(cmd.ExecuteScalar());
                        }


                        string sumAdvSql = @"
SELECT ISNULL(SUM(Amount),0) FROM Advance
WHERE WorkerID=@wid AND YEAR(AdvanceDate)=@y AND MONTH(AdvanceDate)=@m";
                        decimal advanceSum = 0;
                        using (var cmd = new SqlCommand(sumAdvSql, conn, tx))
                        {
                            cmd.Parameters.AddWithValue("@wid", workerId);
                            cmd.Parameters.AddWithValue("@y", year);
                            cmd.Parameters.AddWithValue("@m", month);
                            advanceSum = Convert.ToDecimal(cmd.ExecuteScalar());
                        }

                        decimal gross = Math.Round(totalKg * wageRate, 2);
                        decimal net = Math.Round(gross - advanceSum, 2);


                        string upsert = @"
IF EXISTS (SELECT 1 FROM SalarySettlement WHERE WorkerID=@wid AND SalaryMonth=@sm)
    UPDATE SalarySettlement
    SET TotalKg=@tkg, GrossSalary=@gross, AdvanceAmount=@adv, NetSalary=@net
    WHERE WorkerID=@wid AND SalaryMonth=@sm;
ELSE
    INSERT INTO SalarySettlement (WorkerID, SalaryMonth, TotalKg, GrossSalary, AdvanceAmount, NetSalary, IsPaid)
    VALUES (@wid, @sm, @tkg, @gross, @adv, @net, 0);";
                        using (var cmd = new SqlCommand(upsert, conn, tx))
                        {
                            cmd.Parameters.AddWithValue("@wid", workerId);
                            cmd.Parameters.AddWithValue("@sm", monthStart);
                            cmd.Parameters.AddWithValue("@tkg", totalKg);
                            cmd.Parameters.AddWithValue("@gross", gross);
                            cmd.Parameters.AddWithValue("@adv", advanceSum);
                            cmd.Parameters.AddWithValue("@net", net);
                            cmd.ExecuteNonQuery();
                        }

                        tx.Commit();
                        MessageBox.Show("Harvest saved and settlement updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        try { tx.Rollback(); } catch { }
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            dashboard1 add1 = new dashboard1();
            add1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            add_farmmer_1 add1 = new add_farmmer_1();
            add1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Advance add1 = new Advance();
            add1.Show();
            this.Hide();
        }

        private void Settlment_Click(object sender, EventArgs e)
        {
            Settlement_UI add1 = new Settlement_UI();
            add1.Show();
            this.Hide();
        }
    }
}
