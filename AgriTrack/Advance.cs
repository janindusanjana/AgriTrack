using System;
using System.Data;
using System.Data.SQLite;
using System.Globalization;
using System.Windows.Forms;

namespace AgriTrack
{
    public partial class Advance : Form
    {
        private string connectionString = "data source=C:\\Users\\wwwja\\Desktop\\AgriTrack\\AgriTrackDB.db;";
        private decimal wagePerKg = 50m;
        private long? selectedAdvanceId = null;

        public Advance()
        {
            InitializeComponent();

        
            btnSearchWorker.Click += btnSearchWorker_Click;
        
            btnClearAdvance.Click += btnClearAdvance_Click;
            btnCancelAdvance.Click += btnCancelAdvance_Click;
            dgvAdvanceHistory.SelectionChanged += dgvAdvanceHistory_SelectionChanged;
            txtAdvanceAmount.TextChanged += txtAdvanceAmount_TextChanged;
            dtpAdvanceDate.ValueChanged += dtpAdvanceDate_ValueChanged;
        }

        #region Event handlers

        private void btnSearchWorker_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtWorkerID.Text))
            {
                MessageBox.Show("Enter Worker ID first.");
                return;
            }

            LoadWorkerAndRelatedData(txtWorkerID.Text.Trim());
        }

        private void btnSaveAdvance_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtWorkerID.Text))
            {
                MessageBox.Show("Enter Worker ID before saving.");
                return;
            }

        
            if (!decimal.TryParse(txtAdvanceAmount.Text.Trim(), NumberStyles.Number, CultureInfo.InvariantCulture, out decimal amount))
            {
                MessageBox.Show("Enter a valid numeric advance amount.");
                return;
            }

            if (amount <= 0)
            {
                MessageBox.Show("Advance amount must be greater than zero.");
                return;
            }

            DateTime advDate = dtpAdvanceDate.Value.Date;
            string workerId = txtWorkerID.Text.Trim();

            try
            {
                if (selectedAdvanceId.HasValue)
                {
                    UpdateAdvance(selectedAdvanceId.Value, workerId, amount, advDate);
                    MessageBox.Show("Advance updated successfully.");
                }
                else
                {
                    InsertAdvance(workerId, amount, advDate);
                    MessageBox.Show("Advance saved successfully.");
                }

             
                LoadWorkerAndRelatedData(workerId);
                UpdateSalarySettlementForMonth(workerId, advDate);
                ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving advance: " + ex.Message);
            }
        }

        private void btnClearAdvance_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnCancelAdvance_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvAdvanceHistory_SelectionChanged(object sender, EventArgs e)
        {
            
            if (dgvAdvanceHistory.SelectedRows.Count > 0)
            {
                var row = dgvAdvanceHistory.SelectedRows[0];
                if (row.Cells["AdvanceID"].Value != null)
                {
                    selectedAdvanceId = Convert.ToInt64(row.Cells["AdvanceID"].Value);

                    
                    if (DateTime.TryParse(row.Cells["AdvanceDate"].Value.ToString(), out DateTime dt))
                        dtpAdvanceDate.Value = dt;
                }
            }
            else
            {
                ClearSelection();
            }
        }

        private void txtAdvanceAmount_TextChanged(object sender, EventArgs e)
        {
            
            RecalculatePreview();
        }

        private void dtpAdvanceDate_ValueChanged(object sender, EventArgs e)
        {
           
            RecalculatePreview();
        }

        #endregion

        #region Data operations

        private void LoadWorkerAndRelatedData(string workerId)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT Name, NIC, Phone FROM Worker WHERE WorkerID=@WorkerID";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@WorkerID", workerId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtWorkerName.Text = reader["Name"]?.ToString();
                            txtWorkerNIC.Text = reader["NIC"]?.ToString();
                            txtWorkerPhone.Text = reader["Phone"]?.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Worker not found.");
                            ClearForm();
                            return;
                        }
                    }
                }

                
                string sumQuery = "SELECT IFNULL(SUM(Amount),0) FROM Advance WHERE WorkerID=@WorkerID";
                using (var cmd = new SQLiteCommand(sumQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@WorkerID", workerId);
                    var sumObj = cmd.ExecuteScalar();
                  
                    txtAdvance.Text = Convert.ToDecimal(sumObj).ToString("F2", CultureInfo.InvariantCulture);
                }

              
                string historyQuery = "SELECT AdvanceID, Amount, AdvanceDate FROM Advance WHERE WorkerID=@WorkerID ORDER BY AdvanceDate DESC";
                using (var da = new SQLiteDataAdapter(historyQuery, conn))
                {
                    da.SelectCommand.Parameters.AddWithValue("@WorkerID", workerId);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                  
                    dgvAdvanceHistory.DataSource = null;
                    dgvAdvanceHistory.Columns.Clear();

                    dgvAdvanceHistory.DataSource = dt;

                    if (dgvAdvanceHistory.Columns["Amount"] != null)
                        dgvAdvanceHistory.Columns["Amount"].DefaultCellStyle.Format = "F2";
                    if (dgvAdvanceHistory.Columns["AdvanceDate"] != null)
                        dgvAdvanceHistory.Columns["AdvanceDate"].DefaultCellStyle.Format = "yyyy-MM-dd";

                    dgvAdvanceHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dgvAdvanceHistory.MultiSelect = false;
                }
            }

           
            RecalculatePreview();
        }

        private void InsertAdvance(string workerId, decimal amount, DateTime advDate)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string insertQuery = "INSERT INTO Advance (WorkerID, Amount, AdvanceDate) VALUES (@WorkerID, @Amount, @AdvanceDate)";
                using (var cmd = new SQLiteCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@WorkerID", workerId);
                    cmd.Parameters.AddWithValue("@Amount", amount);
                    cmd.Parameters.AddWithValue("@AdvanceDate", advDate.ToString("yyyy-MM-dd"));
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void UpdateAdvance(long advanceId, string workerId, decimal amount, DateTime advDate)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string updateQuery = "UPDATE Advance SET WorkerID=@WorkerID, Amount=@Amount, AdvanceDate=@AdvanceDate WHERE AdvanceID=@AdvanceID";
                using (var cmd = new SQLiteCommand(updateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@WorkerID", workerId);
                    cmd.Parameters.AddWithValue("@Amount", amount);
                    cmd.Parameters.AddWithValue("@AdvanceDate", advDate.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@AdvanceID", advanceId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void DeleteAdvance(long advanceId)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string deleteQuery = "DELETE FROM Advance WHERE AdvanceID=@AdvanceID";
                using (var cmd = new SQLiteCommand(deleteQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@AdvanceID", advanceId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        #endregion

        #region Salary settlement & preview

        private void RecalculatePreview()
        {
            string workerId = txtWorkerID.Text.Trim();
            if (string.IsNullOrEmpty(workerId))
            {
                txtGrossSalary.Text = "";
               
                txtAdvance.Text = "";
                txtNetSalary.Text = "";
                return;
            }

            DateTime monthDate = dtpAdvanceDate.Value.Date;
            decimal gross = ComputeGrossSalary(workerId, monthDate);
            decimal existingAdvances = GetTotalAdvancesForWorker(workerId);

            
            decimal newAdvance = 0m;
            decimal.TryParse(txtAdvanceAmount.Text.Trim(), NumberStyles.Number, CultureInfo.InvariantCulture, out newAdvance);

            decimal totalAdvanceAfter = existingAdvances + newAdvance;
            decimal net = gross - totalAdvanceAfter;

          
            txtGrossSalary.Text = gross.ToString("F2", CultureInfo.InvariantCulture);
            txtAdvance.Text = totalAdvanceAfter.ToString("F2", CultureInfo.InvariantCulture); 
            txtNetSalary.Text = net.ToString("F2", CultureInfo.InvariantCulture);
        }

        private decimal ComputeGrossSalary(string workerId, DateTime monthDate)
        {
            string monthKey = monthDate.ToString("yyyy-MM", CultureInfo.InvariantCulture);
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string sel = "SELECT GrossSalary FROM SalarySettlement WHERE WorkerID=@WorkerID AND SalaryMonth=@SalaryMonth LIMIT 1";
                using (var cmd = new SQLiteCommand(sel, conn))
                {
                    cmd.Parameters.AddWithValue("@WorkerID", workerId);
                    cmd.Parameters.AddWithValue("@SalaryMonth", monthKey);
                    var obj = cmd.ExecuteScalar();
                    if (obj != null && obj != DBNull.Value)
                    {
                        if (decimal.TryParse(obj.ToString(), out decimal storedGross))
                            return storedGross;
                    }
                }

                
                string harvestQuery = "SELECT IFNULL(SUM(TeaKg),0) FROM Harvest WHERE WorkerID=@WorkerID AND strftime('%Y-%m', HarvestDate)=@SalaryMonth";
                using (var cmd = new SQLiteCommand(harvestQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@WorkerID", workerId);
                    cmd.Parameters.AddWithValue("@SalaryMonth", monthKey);
                    var obj = cmd.ExecuteScalar();
                    decimal totalKg = 0m;
                    if (obj != null && obj != DBNull.Value)
                        totalKg = Convert.ToDecimal(obj);
                    return totalKg * wagePerKg;
                }
            }
        }

        private decimal GetTotalAdvancesForWorker(string workerId)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string sumQuery = "SELECT IFNULL(SUM(Amount),0) FROM Advance WHERE WorkerID=@WorkerID";
                using (var cmd = new SQLiteCommand(sumQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@WorkerID", workerId);
                    var obj = cmd.ExecuteScalar();
                    return Convert.ToDecimal(obj);
                }
            }
        }

        private void UpdateSalarySettlementForMonth(string workerId, DateTime monthDate)
        {
            string monthKey = monthDate.ToString("yyyy-MM", CultureInfo.InvariantCulture);
            decimal gross = ComputeGrossSalary(workerId, monthDate);
            decimal totalAdvances = GetTotalAdvancesForWorker(workerId);
            decimal net = gross - totalAdvances;

            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string check = "SELECT SettlementID FROM SalarySettlement WHERE WorkerID=@WorkerID AND SalaryMonth=@SalaryMonth LIMIT 1";
                object existingId = null;
                using (var cmd = new SQLiteCommand(check, conn))
                {
                    cmd.Parameters.AddWithValue("@WorkerID", workerId);
                    cmd.Parameters.AddWithValue("@SalaryMonth", monthKey);
                    existingId = cmd.ExecuteScalar();
                }

                if (existingId != null && existingId != DBNull.Value)
                {
                    string update = "UPDATE SalarySettlement SET GrossSalary=@GrossSalary, AdvanceAmount=@AdvanceAmount, NetSalary=@NetSalary WHERE SettlementID=@SettlementID";
                    using (var cmd = new SQLiteCommand(update, conn))
                    {
                        cmd.Parameters.AddWithValue("@GrossSalary", gross);
                        cmd.Parameters.AddWithValue("@AdvanceAmount", totalAdvances);
                        cmd.Parameters.AddWithValue("@NetSalary", net);
                        cmd.Parameters.AddWithValue("@SettlementID", Convert.ToInt64(existingId));
                        cmd.ExecuteNonQuery();
                    }
                }
                else
                {
                    string insert = "INSERT INTO SalarySettlement (WorkerID, SalaryMonth, TotalKg, GrossSalary, AdvanceAmount, NetSalary, IsPaid) VALUES (@WorkerID, @SalaryMonth, @TotalKg, @GrossSalary, @AdvanceAmount, @NetSalary, 0)";
                    decimal totalKg = GetTotalKgForMonth(workerId, monthDate);
                    using (var cmd = new SQLiteCommand(insert, conn))
                    {
                        cmd.Parameters.AddWithValue("@WorkerID", workerId);
                        cmd.Parameters.AddWithValue("@SalaryMonth", monthKey);
                        cmd.Parameters.AddWithValue("@TotalKg", totalKg);
                        cmd.Parameters.AddWithValue("@GrossSalary", gross);
                        cmd.Parameters.AddWithValue("@AdvanceAmount", totalAdvances);
                        cmd.Parameters.AddWithValue("@NetSalary", net);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        private decimal GetTotalKgForMonth(string workerId, DateTime monthDate)
        {
            string monthKey = monthDate.ToString("yyyy-MM", CultureInfo.InvariantCulture);
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string q = "SELECT IFNULL(SUM(TeaKg),0) FROM Harvest WHERE WorkerID=@WorkerID AND strftime('%Y-%m', HarvestDate)=@SalaryMonth";
                using (var cmd = new SQLiteCommand(q, conn))
                {
                    cmd.Parameters.AddWithValue("@WorkerID", workerId);
                    cmd.Parameters.AddWithValue("@SalaryMonth", monthKey);
                    var obj = cmd.ExecuteScalar();
                    return Convert.ToDecimal(obj);
                }
            }
        }

        #endregion

        #region Helpers

        private void ClearForm()
        {
            txtWorkerID.Clear();
            txtWorkerName.Clear();
            txtWorkerNIC.Clear();
            txtWorkerPhone.Clear();
            txtAdvanceAmount.Text = "";    
            dtpAdvanceDate.Value = DateTime.Today;
          
            txtGrossSalary.Text = "";
            txtAdvance.Text = "";            
            txtNetSalary.Text = "";
            dgvAdvanceHistory.DataSource = null;
            dgvAdvanceHistory.Columns.Clear();
            selectedAdvanceId = null;
        }

        private void ClearSelection()
        {
            selectedAdvanceId = null;
            dgvAdvanceHistory.ClearSelection();
            
        }

        #endregion
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
