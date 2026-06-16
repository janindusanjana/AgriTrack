using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;
using System.Data.SQLite;

namespace AgriTrack
{
    public partial class dashboard1 : Form
    {
        public dashboard1()
        {
            InitializeComponent();
        }

        private void dashboard1_Load(object sender, EventArgs e)
        {
            LoadHarvestChart();
        }

        private void LoadHarvestChart()
        {
            LiveCharts.WinForms.CartesianChart harvestChart = new LiveCharts.WinForms.CartesianChart();
            harvestChart.Dock = DockStyle.Fill;
            panelChartContainer.Controls.Clear();
            panelChartContainer.Controls.Add(harvestChart);

            ChartValues<double> dailyKilos = new ChartValues<double>();
            List<string> dateLabels = new List<string>();

            // graph ekt pitin data add krl 
            dailyKilos.AddRange(new double[] { 55.2, 68.4, 62.0, 85.3, 78.1, 92.6, 88.5 });
            dateLabels.AddRange(new string[] { "06-11", "06-12", "06-13", "06-14", "06-15", "06-16", "06-17" });

            // comment krl tin tik ain krnna database link krama



            /*
             try
             {
                 using (SQLiteConnection conn = new SQLiteConnection(DatabaseHelper.ConnectionString))
                 {
                     conn.Open();
                     string query = "SELECT HarvestDate, SUM(TeaKg) as TotalKilos FROM Harvest GROUP BY HarvestDate ORDER BY HarvestDate ASC LIMIT 7";

                     using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                     {
                         using (SQLiteDataReader reader = cmd.ExecuteReader())
                         {
                             // Database එකෙන් දත්ත ගන්නවා නම් උඩ තියෙන බොරු දත්ත මකන්න ඕනේ නිසා මේවා Clear කරනවා
                             dailyKilos.Clear();
                             dateLabels.Clear();

                             while (reader.Read())
                             {
                                 dailyKilos.Add(Convert.ToDouble(reader["TotalKilos"]));
                                 dateLabels.Add(reader["HarvestDate"].ToString());
                             }
                         }
                     }
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Error loading chart data: " + ex.Message, "Chart Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
             */

            harvestChart.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Total Harvest (Kg)",
                    Values = dailyKilos,
                    PointGeometrySize = 10,
                    Stroke = System.Windows.Media.Brushes.MediumSeaGreen
                }
            };

            harvestChart.AxisX.Add(new Axis
            {
                Title = "Date",
                Labels = dateLabels
            });

            harvestChart.AxisY.Add(new Axis
            {
                Title = "Kilograms (Kg)",
                LabelFormatter = value => value.ToString("N")
            });
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