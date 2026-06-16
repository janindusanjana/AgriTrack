using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace AgriTrack
{
    public partial class Settlement_UI : Form
    {
        string connectionString = @"data source=C:\Users\wwwja\Desktop\AgriTrack\AgriTrackDB.db;";
        double ratePerKg = 120;

        public Settlement_UI()
        {
            InitializeComponent();

       
            this.Load += Settlement_UI_Load;
            btnSearch.Click += btnSearch_Click;
            btnCalculate.Click += btnCalculate_Click;
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string month = dtpMonth.Value.ToString("yyyy-MM");
                if (!long.TryParse(txtWorkerID.Text.Trim(), out long workerId))
                {
                    MessageBox.Show("Enter a valid numeric Worker ID.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (var con = new SQLiteConnection(connectionString))
                {
                    con.Open();

                   
                    using (var cmd = new SQLiteCommand("SELECT Name FROM Worker WHERE WorkerID = @id;", con))
                    {
                        cmd.Parameters.AddWithValue("@id", workerId);
                        var nameObj = cmd.ExecuteScalar();
                        if (nameObj == null)
                        {
                            MessageBox.Show("Worker not found!", "Not found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtName.Text = "";
                            txtTotalKgPlucked.Text = "0.00";
                            txtTotalAdvance.Text = "0.00";
                            txtGrossSalary.Text = "";
                            txtNetSalary.Text = "";
                            return;
                        }
                        txtName.Text = nameObj.ToString();
                    }

                  
                    double totalKg = 0.0;
                    int harvestRows = 0;
                    using (var cmd = new SQLiteCommand(@"
                SELECT HarvestDate, TeaKg
                FROM Harvest
                WHERE WorkerID = @id
                ORDER BY HarvestDate;
            ", con))
                    {
                        cmd.Parameters.AddWithValue("@id", workerId);
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                harvestRows++;
                                var dateObj = reader["HarvestDate"];
                                var kgObj = reader["TeaKg"];

                                if (dateObj == DBNull.Value || dateObj == null) continue;

                                string dateStr = dateObj.ToString();
                                if (!DateTime.TryParse(dateStr, System.Globalization.CultureInfo.CurrentCulture, System.Globalization.DateTimeStyles.None, out DateTime dt)
                                    && !DateTime.TryParse(dateStr, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out dt))
                                {
                                 
                                    continue;
                                }

                                if (dt.ToString("yyyy-MM") == month)
                                {
                                    if (kgObj != DBNull.Value && double.TryParse(kgObj.ToString(), out double kg))
                                        totalKg += kg;
                                }
                            }
                        }
                    }
                    txtTotalKgPlucked.Text = totalKg.ToString("F2");

                  
                    double totalAdvance = 0.0;
                    int advanceRows = 0;
                    using (var cmd = new SQLiteCommand(@"
                SELECT AdvanceDate, Amount
                FROM Advance
                WHERE WorkerID = @id
                ORDER BY AdvanceDate;
            ", con))
                    {
                        cmd.Parameters.AddWithValue("@id", workerId);
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                advanceRows++;
                                var dateObj = reader["AdvanceDate"];
                                var amtObj = reader["Amount"];

                                if (dateObj == DBNull.Value || dateObj == null) continue;

                                string dateStr = dateObj.ToString();
                                if (!DateTime.TryParse(dateStr, System.Globalization.CultureInfo.CurrentCulture, System.Globalization.DateTimeStyles.None, out DateTime dt)
                                    && !DateTime.TryParse(dateStr, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out dt))
                                {
                                    continue;
                                }

                                if (dt.ToString("yyyy-MM") == month)
                                {
                                    if (amtObj != DBNull.Value && double.TryParse(amtObj.ToString(), out double amt))
                                        totalAdvance += amt;
                                }
                            }
                        }
                    }
                    txtTotalAdvance.Text = totalAdvance.ToString("F2");

                    
                    double grossSalary = totalKg * ratePerKg;
                    double netSalary = grossSalary - totalAdvance;
                    txtGrossSalary.Text = grossSalary.ToString("F2");
                    txtNetSalary.Text = netSalary.ToString("F2");

                  
                    using (var cmd = new SQLiteCommand(@"
                SELECT TotalKg, GrossSalary, AdvanceAmount, NetSalary, IsPaid
                FROM SalarySettlement
                WHERE WorkerID = @id
                  AND SalaryMonth = @month
                LIMIT 1;
            ", con))
                    {
                        cmd.Parameters.AddWithValue("@id", workerId);
                        cmd.Parameters.AddWithValue("@month", month);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                               
                                txtTotalKgPlucked.Text = Convert.ToDouble(reader["TotalKg"] ?? 0).ToString("F2");
                                txtGrossSalary.Text = Convert.ToDouble(reader["GrossSalary"] ?? 0).ToString("F2");
                                txtTotalAdvance.Text = Convert.ToDouble(reader["AdvanceAmount"] ?? 0).ToString("F2");
                                txtNetSalary.Text = Convert.ToDouble(reader["NetSalary"] ?? 0).ToString("F2");

                                int isPaid = Convert.ToInt32(reader["IsPaid"] ?? 0);
                                cmbstatus.Text = (isPaid == 1) ? "Paid" : "Non-Paid";
                            }
                            else
                            {
                                
                                cmbstatus.Text = "Non-Paid";
                            }
                        }
                    }

                  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double kg = 0;
            double advance = 0;

            double.TryParse(txtTotalKgPlucked.Text, out kg);
            double.TryParse(txtTotalAdvance.Text, out advance);

            double grossSalary = kg * ratePerKg;
            double netSalary = grossSalary - advance;

            txtGrossSalary.Text = grossSalary.ToString("F2");
            txtNetSalary.Text = netSalary.ToString("F2");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string month = dtpMonth.Value.ToString("yyyy-MM");
            int paid = (cmbstatus.Text == "Paid") ? 1 : 0;

            using (SQLiteConnection con = new SQLiteConnection(connectionString))
            {
                con.Open();

                string query = @"
                    INSERT OR REPLACE INTO SalarySettlement
                    (
                        WorkerID,
                        SalaryMonth,
                        TotalKg,
                        GrossSalary,
                        AdvanceAmount,
                        NetSalary,
                        IsPaid,
                        PaidDate
                    )
                    VALUES
                    (
                        @WorkerID,
                        @SalaryMonth,
                        @TotalKg,
                        @GrossSalary,
                        @AdvanceAmount,
                        @NetSalary,
                        @IsPaid,
                        @PaidDate
                    )";

                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@WorkerID", txtWorkerID.Text);
                    cmd.Parameters.AddWithValue("@SalaryMonth", month);
                    cmd.Parameters.AddWithValue("@TotalKg", txtTotalKgPlucked.Text);
                    cmd.Parameters.AddWithValue("@GrossSalary", txtGrossSalary.Text);
                    cmd.Parameters.AddWithValue("@AdvanceAmount", txtTotalAdvance.Text);
                    cmd.Parameters.AddWithValue("@NetSalary", txtNetSalary.Text);
                    cmd.Parameters.AddWithValue("@IsPaid", paid);
                    cmd.Parameters.AddWithValue("@PaidDate", DateTime.Now.ToString("yyyy-MM-dd"));

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Settlement Updated Successfully");
            }

            LoadData();
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

            this.Show();
        }

        private void LoadData()
        {
            using (SQLiteConnection con = new SQLiteConnection(connectionString))
            {
                con.Open();

                string query = @"
                    SELECT
                        WorkerID,
                        TotalKg,
                        AdvanceAmount,
                        NetSalary,
                        CASE WHEN IsPaid=1 THEN 'Paid' ELSE 'Non-Paid' END AS Status
                    FROM SalarySettlement
                    ORDER BY WorkerID, SalaryMonth;
                ";

                using (SQLiteDataAdapter da = new SQLiteDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);

  
                    dgvSettlement.DataSource = null;
                    dgvSettlement.Columns.Clear();
                    dgvSettlement.AutoGenerateColumns = true;
                    dgvSettlement.DataSource = dt;

             
                    if (dgvSettlement.Columns["TotalKg"] != null)
                        dgvSettlement.Columns["TotalKg"].DefaultCellStyle.Format = "N2";
                    if (dgvSettlement.Columns["AdvanceAmount"] != null)
                        dgvSettlement.Columns["AdvanceAmount"].DefaultCellStyle.Format = "N2";
                    if (dgvSettlement.Columns["NetSalary"] != null)
                        dgvSettlement.Columns["NetSalary"].DefaultCellStyle.Format = "N2";
                }
            }
        }

        private void Settlement_UI_Load(object sender, EventArgs e)
        {
       
            if (cmbstatus.Items.Count >= 2)
            {
                cmbstatus.SelectedIndex = 1;
            }

       
            dgvSettlement.AutoGenerateColumns = true;

            LoadData();
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (PdfSharp.Fonts.GlobalFontSettings.FontResolver == null)
            {
                PdfSharp.Fonts.GlobalFontSettings.FontResolver = new FontResolver.PdfSharp.FontResolverPdfSharp();
            }

            try
            {
                
                string targetMonth = dtpMonth.Text;         
                string workerId = txtWorkerID.Text;           
                string workerName = txtName.Text;             
                string totalKg = txtTotalKgPlucked.Text;      
                string totalAdvance = txtTotalAdvance.Text;   
                string grossSalary = txtGrossSalary.Text;     
                string netSalary = txtNetSalary.Text;         
                string salaryStatus = cmbstatus.Text;   

                
                if (string.IsNullOrEmpty(workerId) || string.IsNullOrEmpty(workerName))
                {
                    MessageBox.Show("Please load and search for a worker before printing.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                
                string safeMonthString = targetMonth.Replace("/", "-");
                string pdfPath = $"Settlement_{workerId}_{safeMonthString}.pdf";

                
                SettlementPDFGenerator.GenerateReceipt(
                    pdfPath,
                    targetMonth,
                    workerId,
                    workerName,
                    totalKg,
                    totalAdvance,
                    grossSalary,
                    netSalary,
                    salaryStatus
                );

                
                MessageBox.Show($"Invoice generated successfully: {pdfPath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(pdfPath) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error printing settlement document: {ex.Message}", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
