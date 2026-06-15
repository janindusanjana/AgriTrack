using System;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace AgriTrack
{
    public partial class DailyHarvestAdding : Form
    {
      
        private string connectionString = "Data Source=C:\\Users\\wwwja\\Desktop\\AgriTrack\\AgriTrackDB.db";

        
        private const decimal DEFAULT_WAGE_RATE = 50.00m;

        public DailyHarvestAdding()
        {
            InitializeComponent();

         
            txtWageRate.ReadOnly = true;

        
            btnSave.Click += btnSave_Click;
            btnClear.Click += btnClear_Click;
            btnSearch.Click += btnSearch_Click;
            this.Load += DailyHarvestAdding_Load;
        }

       
        private void DailyHarvestAdding_Load(object sender, EventArgs e)
        {
            PopulateInitialWageRate();
            UpdateTotalHarvestToday();
        }

     
        private void PopulateInitialWageRate()
        {
            decimal displayRate = DEFAULT_WAGE_RATE;

            try
            {
                using (var conn = new SqliteConnection(connectionString))
                {
                    conn.Open();
                    string sql = "SELECT Value FROM Settings WHERE Key = 'DefaultWageRate' LIMIT 1;";
                    using (var cmd = new SqliteCommand(sql, conn))
                    {
                        var val = cmd.ExecuteScalar();
                        if (val != null && val != DBNull.Value)
                        {
                            if (decimal.TryParse(val.ToString(), out decimal parsed))
                                displayRate = parsed;
                        }
                    }
                }
            }
            catch
            {
                displayRate = DEFAULT_WAGE_RATE;
            }

            txtWageRate.Text = displayRate.ToString("0.##");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
       
            txtWorkerId.Text = "";
            txtWorkerName.Text = "";
            numPluckedKg.Value = 0;
            dtpDate.Value = DateTime.Today;
         
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!long.TryParse(txtWorkerId.Text.Trim(), out long workerId))
            {
                txtWorkerName.Text = "";
                return;
            }

            using (var conn = new SqliteConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT Name FROM Worker WHERE WorkerID = @wid LIMIT 1;";
                using (var cmd = new SqliteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@wid", workerId);
                    var res = cmd.ExecuteScalar();
                    txtWorkerName.Text = (res != null && res != DBNull.Value) ? res.ToString() : "";
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!long.TryParse(txtWorkerId.Text.Trim(), out long workerId))
            {
                MessageBox.Show("Invalid Worker Id", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtWageRate.Text.Trim(), out decimal wageRate) || wageRate <= 0)
            {
                MessageBox.Show("Invalid wage rate. Please reopen the form or contact admin.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal pluckedKg = numPluckedKg.Value;
            if (pluckedKg <= 0)
            {
                MessageBox.Show("Plucked kilos must be greater than 0", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime harvestDate = dtpDate.Value.Date;

            using (var conn = new SqliteConnection(connectionString))
            {
                conn.Open();
                using (var tx = conn.BeginTransaction())
                {
                    try
                    {
                     
                        string insertHarvest = @"
INSERT INTO Harvest (WorkerID, HarvestDate, TeaKg)
VALUES (@wid, @hdate, @kg);";
                        using (var cmd = new SqliteCommand(insertHarvest, conn, tx))
                        {
                            cmd.Parameters.AddWithValue("@wid", workerId);
                            cmd.Parameters.AddWithValue("@hdate", harvestDate.ToString("yyyy-MM-dd"));
                            cmd.Parameters.AddWithValue("@kg", pluckedKg);
                            cmd.Parameters.AddWithValue("@ts", DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss"));
                            cmd.ExecuteNonQuery();
                        }

                    
                        string yearStr = harvestDate.Year.ToString("D4");
                        string monthStr = harvestDate.Month.ToString("D2");
                        string monthStartIso = new DateTime(harvestDate.Year, harvestDate.Month, 1).ToString("yyyy-MM-dd");

                        string sumKgSql = @"
SELECT COALESCE(SUM(TeaKg), 0) FROM Harvest
WHERE WorkerID = @wid AND strftime('%Y', HarvestDate) = @y AND strftime('%m', HarvestDate) = @m;";
                        decimal totalKg = 0m;
                        using (var cmd = new SqliteCommand(sumKgSql, conn, tx))
                        {
                            cmd.Parameters.AddWithValue("@wid", workerId);
                            cmd.Parameters.AddWithValue("@y", yearStr);
                            cmd.Parameters.AddWithValue("@m", monthStr);
                            var scalar = cmd.ExecuteScalar();
                            totalKg = Convert.ToDecimal(scalar ?? 0m);
                        }

                        string sumAdvSql = @"
SELECT COALESCE(SUM(Amount), 0) FROM Advance
WHERE WorkerID = @wid AND strftime('%Y', AdvanceDate) = @y AND strftime('%m', AdvanceDate) = @m;";
                        decimal advanceSum = 0m;
                        using (var cmd = new SqliteCommand(sumAdvSql, conn, tx))
                        {
                            cmd.Parameters.AddWithValue("@wid", workerId);
                            cmd.Parameters.AddWithValue("@y", yearStr);
                            cmd.Parameters.AddWithValue("@m", monthStr);
                            var scalar = cmd.ExecuteScalar();
                            advanceSum = Convert.ToDecimal(scalar ?? 0m);
                        }

                        decimal gross = Math.Round(totalKg * wageRate, 2);
                        decimal net = Math.Round(gross - advanceSum, 2);

                      
                        string updateSql = @"
UPDATE SalarySettlement
SET TotalKg = @tkg, GrossSalary = @gross, AdvanceAmount = @adv, NetSalary = @net
WHERE WorkerID = @wid AND SalaryMonth = @sm;";
                        using (var cmd = new SqliteCommand(updateSql, conn, tx))
                        {
                            cmd.Parameters.AddWithValue("@tkg", totalKg);
                            cmd.Parameters.AddWithValue("@gross", gross);
                            cmd.Parameters.AddWithValue("@adv", advanceSum);
                            cmd.Parameters.AddWithValue("@net", net);
                            cmd.Parameters.AddWithValue("@wid", workerId);
                            cmd.Parameters.AddWithValue("@sm", monthStartIso);
                            int rows = cmd.ExecuteNonQuery();
                            if (rows == 0)
                            {
                                string insertSettlement = @"
INSERT INTO SalarySettlement (WorkerID, SalaryMonth, TotalKg, GrossSalary, AdvanceAmount, NetSalary, IsPaid)
VALUES (@wid, @sm, @tkg, @gross, @adv, @net, 0);";
                                using (var ins = new SqliteCommand(insertSettlement, conn, tx))
                                {
                                    ins.Parameters.AddWithValue("@wid", workerId);
                                    ins.Parameters.AddWithValue("@sm", monthStartIso);
                                    ins.Parameters.AddWithValue("@tkg", totalKg);
                                    ins.Parameters.AddWithValue("@gross", gross);
                                    ins.Parameters.AddWithValue("@adv", advanceSum);
                                    ins.Parameters.AddWithValue("@net", net);
                                    ins.ExecuteNonQuery();
                                }
                            }
                        }

                        tx.Commit();

                        
                        UpdateTotalHarvestToday();

                        MessageBox.Show("Harvest saved and settlement updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        try { tx.Rollback(); } catch { }
                        MessageBox.Show("Error saving harvest: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

      
        private void UpdateTotalHarvestToday()
        {
            DateTime today = DateTime.Today;
            string y = today.Year.ToString("D4");
            string m = today.Month.ToString("D2");
            string d = today.Day.ToString("D2");

            using (var conn = new SqliteConnection(connectionString))
            {
                conn.Open();
                string sql = @"
SELECT COALESCE(SUM(TeaKg), 0) FROM Harvest
WHERE strftime('%Y', HarvestDate) = @y AND strftime('%m', HarvestDate) = @m AND strftime('%d', HarvestDate) = @d;";
                using (var cmd = new SqliteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@y", y);
                    cmd.Parameters.AddWithValue("@m", m);
                    cmd.Parameters.AddWithValue("@d", d);
                    var scalar = cmd.ExecuteScalar();
                    decimal todayTotal = Convert.ToDecimal(scalar ?? 0m);
                    txtTotalHarvest.Text = todayTotal.ToString("0.##");
                }
            }
        }
    }
}
