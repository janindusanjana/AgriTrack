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
            this.btnPrint.Click += btnPrint_Click;
        }


        private void Daily_Harvest_Load(object sender, EventArgs e)
        {

            dateTimePicker1.Value = DateTime.Today;


            LoadHarvestData(DateTime.Today);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                
                string targetDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                DataGridView activeGrid = dataGridView1;

                if (activeGrid.Rows.Count == 0 || (activeGrid.Rows.Count == 1 && activeGrid.Rows[0].IsNewRow))
                {
                    MessageBox.Show("There is no table data currently loaded to print.",
                        "Export Canceled", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string pdfPath = System.IO.Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                    $"AgriTrack_DailyHarvest_{targetDate}.pdf");

                
                string totalKilos = textBox1.Text;

                
                DailyHarvestPDFGenerator.GenerateGridReport(pdfPath, targetDate, activeGrid, totalKilos);

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
        public static class DailyHarvestPDFGenerator
        {
            public static void GenerateGridReport(string filename, string targetDate, DataGridView uiGrid, string totalHarvest)
            {
                if (PdfSharp.Fonts.GlobalFontSettings.FontResolver == null)
                {
                    PdfSharp.Fonts.GlobalFontSettings.FontResolver = new WindowsFontResolver();
                }

                MigraDoc.DocumentObjectModel.Document document = new MigraDoc.DocumentObjectModel.Document();
                document.Info.Title = $"AgriTrack Daily Harvest - {targetDate}";

                MigraDoc.DocumentObjectModel.Color agritrackGreen = MigraDoc.DocumentObjectModel.Color.FromRgb(30, 112, 67);
                MigraDoc.DocumentObjectModel.Color darkGray = MigraDoc.DocumentObjectModel.Color.FromRgb(51, 51, 51);

                MigraDoc.DocumentObjectModel.Style style = document.Styles["Normal"];
                style.Font.Name = "Segoe UI";
                style.Font.Size = 10.5;
                style.Font.Color = darkGray;

                MigraDoc.DocumentObjectModel.Section section = document.AddSection();
                section.PageSetup.PageFormat = MigraDoc.DocumentObjectModel.PageFormat.A4;
                section.PageSetup.LeftMargin = "2.0cm";
                section.PageSetup.RightMargin = "2.0cm";

                MigraDoc.DocumentObjectModel.Paragraph brand = section.AddParagraph();
                brand.AddText("AGRITRACK");
                brand.Format.Font.Size = 22;
                brand.Format.Font.Bold = true;
                brand.Format.Font.Color = agritrackGreen;

                MigraDoc.DocumentObjectModel.Paragraph docTitle = section.AddParagraph();
                docTitle.AddText($"DAILY HARVEST SUMMARY — DATE: {targetDate}");
                docTitle.Format.Font.Size = 11;
                docTitle.Format.Font.Bold = true;
                docTitle.Format.Font.Color = MigraDoc.DocumentObjectModel.Colors.Gray;
                docTitle.Format.SpaceAfter = 20;

                MigraDoc.DocumentObjectModel.Tables.Table pdfTable = section.AddTable();
                pdfTable.Borders.Width = 0.5;
                pdfTable.Borders.Color = MigraDoc.DocumentObjectModel.Colors.LightGray;

                
                pdfTable.AddColumn("3.0cm");  
                pdfTable.AddColumn("6.0cm");  
                pdfTable.AddColumn("4.0cm");  
                pdfTable.AddColumn("4.0cm");  

                MigraDoc.DocumentObjectModel.Tables.Row headerRow = pdfTable.AddRow();
                headerRow.Shading.Color = agritrackGreen;
                headerRow.Format.Font.Color = MigraDoc.DocumentObjectModel.Colors.White;
                headerRow.Format.Font.Bold = true;
                headerRow.Height = "0.8cm";
                headerRow.VerticalAlignment = MigraDoc.DocumentObjectModel.Tables.VerticalAlignment.Center;

                headerRow.Cells[0].AddParagraph(" ID");
                headerRow.Cells[1].AddParagraph(" Worker Name");
                headerRow.Cells[2].AddParagraph(" Harvest (Kg)").Format.Alignment = MigraDoc.DocumentObjectModel.ParagraphAlignment.Right;
                headerRow.Cells[3].AddParagraph(" Status").Format.Alignment = MigraDoc.DocumentObjectModel.ParagraphAlignment.Center;

                int addedRowsCount = 0;
                foreach (DataGridViewRow uiRow in uiGrid.Rows)
                {
                    if (uiRow.IsNewRow) continue;

                    string cellId = uiRow.Cells[0].Value?.ToString() ?? "—";
                    string cellName = uiRow.Cells[1].Value?.ToString() ?? "—";
                    string cellKg = uiRow.Cells[2].Value?.ToString() ?? "0.00";
                    string cellStatus = uiRow.Cells[3].Value?.ToString() ?? "—";

                    MigraDoc.DocumentObjectModel.Tables.Row pdfDataRow = pdfTable.AddRow();
                    pdfDataRow.Height = "0.75cm";
                    pdfDataRow.VerticalAlignment = MigraDoc.DocumentObjectModel.Tables.VerticalAlignment.Center;

                    if (addedRowsCount % 2 == 1)
                    {
                        pdfDataRow.Shading.Color = MigraDoc.DocumentObjectModel.Color.FromRgb(248, 249, 250);
                    }

                    pdfDataRow.Cells[0].AddParagraph(" " + cellId);
                    pdfDataRow.Cells[1].AddParagraph(" " + cellName);

                    pdfDataRow.Cells[2].AddParagraph(cellKg).Format.Alignment = MigraDoc.DocumentObjectModel.ParagraphAlignment.Right;

                    var pStat = pdfDataRow.Cells[3].AddParagraph(cellStatus);
                    pStat.Format.Alignment = MigraDoc.DocumentObjectModel.ParagraphAlignment.Center;

                    addedRowsCount++;
                }

                
                section.AddParagraph().Format.SpaceAfter = 20;
                MigraDoc.DocumentObjectModel.Paragraph totalsLine = section.AddParagraph();
                totalsLine.Format.Borders.Top.Width = 1;
                totalsLine.Format.Borders.Top.Color = agritrackGreen;
                totalsLine.Format.SpaceBefore = 10;

                totalsLine.AddText($"Total Processed Ledger Entries: {addedRowsCount} records.");
                totalsLine.Format.Font.Size = 9.5;
                totalsLine.Format.Font.Color = MigraDoc.DocumentObjectModel.Colors.SlateGray;

               
                MigraDoc.DocumentObjectModel.Paragraph grandTotal = section.AddParagraph();
                grandTotal.Format.SpaceBefore = 10;
                grandTotal.Format.Alignment = MigraDoc.DocumentObjectModel.ParagraphAlignment.Right;
                grandTotal.AddFormattedText("Total Daily Harvest: ", MigraDoc.DocumentObjectModel.TextFormat.Bold);

                var totalText = grandTotal.AddFormattedText(string.IsNullOrWhiteSpace(totalHarvest) ? "0.00 Kg" : totalHarvest);
                totalText.Color = agritrackGreen;
                totalText.Font.Size = 14;
                totalText.Font.Bold = true;

                MigraDoc.Rendering.PdfDocumentRenderer renderer = new MigraDoc.Rendering.PdfDocumentRenderer(true) { Document = document };
                renderer.RenderDocument();
                renderer.PdfDocument.Save(filename);
            }
        }
    }
}