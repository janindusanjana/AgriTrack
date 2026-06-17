using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;

namespace AgriTrack.Admin_Forms
{
    public partial class Advance_Settlement : Form
    {

        string connectionString = "Data Source=" + System.IO.Path.Combine(Application.StartupPath, "AgriTrackDB.db") + ";";

        public Advance_Settlement()
        {
            InitializeComponent();

            this.Load += Advance_Settlement_Load;
            btnLoadAdvanceReport.Click += BtnLoadAdvanceReport_Click;
            btnUpdateSettlemet.Click += BtnUpdateSettlemet_Click;
            btnSettlementPrint.Click += BtnSettlementPrint_Click;
        }

        private void Advance_Settlement_Load(object sender, EventArgs e)
        {
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            
            dateTimePicker2.CustomFormat = "MM/yyyy";
            dateTimePicker2.ShowUpDown = true;

            
        }
        private void BtnSettlementPrint_Click(object sender, EventArgs e)
        {
            try
            {
                string targetMonth = dateTimePicker2.Value.ToString("MM/yyyy");
                DataGridView activeGrid = dataGridView1;

                if (activeGrid.Rows.Count == 0 || (activeGrid.Rows.Count == 1 && activeGrid.Rows[0].IsNewRow))
                {
                    MessageBox.Show("There is no table data currently loaded to print.",
                        "Export Canceled", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string safeMonth = targetMonth.Replace("/", "-");
                string pdfPath = System.IO.Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                    $"AgriTrack_Advance_Report_{safeMonth}.pdf");

                AdvanceReportPDFGenerator.GenerateGridReport(pdfPath, targetMonth, activeGrid);

                MessageBox.Show($"Report compiled into PDF:\n{pdfPath}",
                    "Print Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(pdfPath) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating PDF:\n{ex.Message}",
                    "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnLoadAdvanceReport_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            
            string selectedMonth = dateTimePicker2.Value.ToString("yyyy-MM");

            string query = @"
                SELECT 
                    s.WorkerID, 
                    w.Name AS WorkerName, 
                    s.AdvanceAmount, 
                    s.NetSalary, 
                    s.TotalKg, 
                    s.IsPaid 
                FROM SalarySettlement s
                INNER JOIN Worker w ON s.WorkerID = w.WorkerID
                WHERE s.SalaryMonth = @SalaryMonth";

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@SalaryMonth", selectedMonth);

                    try
                    {
                        conn.Open();

                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string workerId = reader["WorkerID"].ToString();
                                string workerName = reader["WorkerName"].ToString();
                                string advance = reader["AdvanceAmount"] != DBNull.Value ? reader["AdvanceAmount"].ToString() : "0";
                                string netSalary = reader["NetSalary"] != DBNull.Value ? reader["NetSalary"].ToString() : "0";
                                string kilos = reader["TotalKg"] != DBNull.Value ? reader["TotalKg"].ToString() : "0";

                                bool isPaid = false;
                                if (reader["IsPaid"] != DBNull.Value)
                                {
                                    isPaid = Convert.ToInt64(reader["IsPaid"]) == 1;
                                }

                                dataGridView1.Rows.Add(workerId, workerName, advance, netSalary, kilos, isPaid);
                            }
                        }

                        if (dataGridView1.Rows.Count == 0)
                        {
                            MessageBox.Show("No records found for the selected month.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading report: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void BtnUpdateSettlemet_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No data to update. Please load a report first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            string selectedMonth = dateTimePicker2.Value.ToString("yyyy-MM");

            string updateQuery = @"
                UPDATE SalarySettlement 
                SET IsPaid = @IsPaid 
                WHERE WorkerID = @WorkerID AND SalaryMonth = @SalaryMonth";

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    using (SQLiteTransaction transaction = conn.BeginTransaction())
                    {
                        using (SQLiteCommand cmd = new SQLiteCommand(updateQuery, conn))
                        {
                            cmd.Transaction = transaction;

                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                if (!row.IsNewRow)
                                {
                                    long workerId = Convert.ToInt64(row.Cells[0].Value);

                                    long isPaidStatus = 0;
                                    
                                    if (row.Cells[5].Value != null && (bool)row.Cells[5].Value == true)
                                    {
                                        isPaidStatus = 1;
                                    }

                                    cmd.Parameters.Clear();
                                    cmd.Parameters.AddWithValue("@IsPaid", isPaidStatus);
                                    cmd.Parameters.AddWithValue("@WorkerID", workerId);
                                    cmd.Parameters.AddWithValue("@SalaryMonth", selectedMonth);

                                    cmd.ExecuteNonQuery();
                                }
                            }
                        }
                        transaction.Commit();
                    }

                    MessageBox.Show("Payment statuses updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        private void button3_Click(object sender, EventArgs e)
        {
            Daily_Harvest dailyHarvestAdding = new Daily_Harvest();
            dailyHarvestAdding.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void Settlment_Click(object sender, EventArgs e)
        {
            
        }
        public static class AdvanceReportPDFGenerator
        {
            public static void GenerateGridReport(string filename, string targetMonth, DataGridView uiGrid)
            {
                if (PdfSharp.Fonts.GlobalFontSettings.FontResolver == null)
                {
                    PdfSharp.Fonts.GlobalFontSettings.FontResolver = new WindowsFontResolver();
                }

                MigraDoc.DocumentObjectModel.Document document = new MigraDoc.DocumentObjectModel.Document();
                document.Info.Title = $"AgriTrack Advance Summary - {targetMonth.Replace("/", "-")}";

                MigraDoc.DocumentObjectModel.Color agritrackGreen = MigraDoc.DocumentObjectModel.Color.FromRgb(30, 112, 67);
                MigraDoc.DocumentObjectModel.Color darkGray = MigraDoc.DocumentObjectModel.Color.FromRgb(51, 51, 51);

                MigraDoc.DocumentObjectModel.Style style = document.Styles["Normal"];
                style.Font.Name = "Segoe UI";
                style.Font.Size = 10;
                style.Font.Color = darkGray;

                MigraDoc.DocumentObjectModel.Section section = document.AddSection();
                section.PageSetup.PageFormat = MigraDoc.DocumentObjectModel.PageFormat.A4;
                section.PageSetup.LeftMargin = "1.5cm";
                section.PageSetup.RightMargin = "1.5cm";

                MigraDoc.DocumentObjectModel.Paragraph brand = section.AddParagraph();
                brand.AddText("AGRITRACK");
                brand.Format.Font.Size = 22;
                brand.Format.Font.Bold = true;
                brand.Format.Font.Color = agritrackGreen;

                MigraDoc.DocumentObjectModel.Paragraph docTitle = section.AddParagraph();
                docTitle.AddText($"ADVANCE REPORT SUMMARY — PERIOD: {targetMonth}");
                docTitle.Format.Font.Size = 11;
                docTitle.Format.Font.Bold = true;
                docTitle.Format.Font.Color = MigraDoc.DocumentObjectModel.Colors.Gray;
                docTitle.Format.SpaceAfter = 20;

                MigraDoc.DocumentObjectModel.Tables.Table pdfTable = section.AddTable();
                pdfTable.Borders.Width = 0.5;
                pdfTable.Borders.Color = MigraDoc.DocumentObjectModel.Colors.LightGray;

                
                pdfTable.AddColumn("2.0cm");  
                pdfTable.AddColumn("4.0cm");  
                pdfTable.AddColumn("2.5cm");  
                pdfTable.AddColumn("2.5cm"); 
                pdfTable.AddColumn("2.5cm");  
                pdfTable.AddColumn("2.5cm");  

                MigraDoc.DocumentObjectModel.Tables.Row headerRow = pdfTable.AddRow();
                headerRow.Shading.Color = agritrackGreen;
                headerRow.Format.Font.Color = MigraDoc.DocumentObjectModel.Colors.White;
                headerRow.Format.Font.Bold = true;
                headerRow.Height = "0.8cm";
                headerRow.VerticalAlignment = MigraDoc.DocumentObjectModel.Tables.VerticalAlignment.Center;

                headerRow.Cells[0].AddParagraph(" ID");
                headerRow.Cells[1].AddParagraph(" Name");
                headerRow.Cells[2].AddParagraph(" Advance").Format.Alignment = MigraDoc.DocumentObjectModel.ParagraphAlignment.Right;
                headerRow.Cells[3].AddParagraph(" Net Salary").Format.Alignment = MigraDoc.DocumentObjectModel.ParagraphAlignment.Right;
                headerRow.Cells[4].AddParagraph(" Kilos").Format.Alignment = MigraDoc.DocumentObjectModel.ParagraphAlignment.Right;
                headerRow.Cells[5].AddParagraph(" Status").Format.Alignment = MigraDoc.DocumentObjectModel.ParagraphAlignment.Center;

                int addedRowsCount = 0;
                foreach (DataGridViewRow uiRow in uiGrid.Rows)
                {
                    if (uiRow.IsNewRow) continue;

                    string cellWorkerId = uiRow.Cells[0].Value?.ToString() ?? "—";
                    string cellWorkerName = uiRow.Cells[1].Value?.ToString() ?? "—";
                    string cellAdvance = uiRow.Cells[2].Value?.ToString() ?? "0.00";
                    string cellNetSalary = uiRow.Cells[3].Value?.ToString() ?? "0.00";
                    string cellKilos = uiRow.Cells[4].Value?.ToString() ?? "0.00";

                    
                    bool isPaidBool = uiRow.Cells[5].Value != null && (bool)uiRow.Cells[5].Value;
                    string cellStatus = isPaidBool ? "Paid" : "Pending";

                    MigraDoc.DocumentObjectModel.Tables.Row pdfDataRow = pdfTable.AddRow();
                    pdfDataRow.Height = "0.75cm";
                    pdfDataRow.VerticalAlignment = MigraDoc.DocumentObjectModel.Tables.VerticalAlignment.Center;

                    if (addedRowsCount % 2 == 1)
                    {
                        pdfDataRow.Shading.Color = MigraDoc.DocumentObjectModel.Color.FromRgb(248, 249, 250);
                    }

                    pdfDataRow.Cells[0].AddParagraph(" " + cellWorkerId);
                    pdfDataRow.Cells[1].AddParagraph(" " + cellWorkerName);

                    pdfDataRow.Cells[2].AddParagraph(cellAdvance).Format.Alignment = MigraDoc.DocumentObjectModel.ParagraphAlignment.Right;
                    pdfDataRow.Cells[3].AddParagraph(cellNetSalary).Format.Alignment = MigraDoc.DocumentObjectModel.ParagraphAlignment.Right;
                    pdfDataRow.Cells[4].AddParagraph(cellKilos).Format.Alignment = MigraDoc.DocumentObjectModel.ParagraphAlignment.Right;

                    var pStat = pdfDataRow.Cells[5].AddParagraph(cellStatus);
                    pStat.Format.Alignment = MigraDoc.DocumentObjectModel.ParagraphAlignment.Center;
                    pStat.Format.Font.Bold = true;

                    if (isPaidBool)
                        pStat.Format.Font.Color = agritrackGreen;
                    else
                        pStat.Format.Font.Color = MigraDoc.DocumentObjectModel.Color.FromRgb(198, 40, 40);

                    addedRowsCount++;
                }

                section.AddParagraph().Format.SpaceAfter = 25;
                MigraDoc.DocumentObjectModel.Paragraph totalsLine = section.AddParagraph();
                totalsLine.Format.Borders.Top.Width = 1;
                totalsLine.Format.Borders.Top.Color = agritrackGreen;
                totalsLine.Format.SpaceBefore = 10;

                totalsLine.AddText($"Total Processed Ledger Entries: {addedRowsCount} records.");
                totalsLine.Format.Font.Size = 9.5;
                totalsLine.Format.Font.Color = MigraDoc.DocumentObjectModel.Colors.SlateGray;

                MigraDoc.Rendering.PdfDocumentRenderer renderer = new MigraDoc.Rendering.PdfDocumentRenderer(true) { Document = document };
                renderer.RenderDocument();
                renderer.PdfDocument.Save(filename);
            }
        }
    }
}