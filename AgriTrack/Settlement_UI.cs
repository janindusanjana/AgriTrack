using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgriTrack
{
    public partial class Settlement_UI : Form
    {
        public Settlement_UI()
        {
            InitializeComponent();
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
