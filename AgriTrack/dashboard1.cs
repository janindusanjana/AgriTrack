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

            using (SQLiteConnection conn = new SQLiteConnection(DatabaseHelper.ConnectionString))
            {
                conn.Open();
                string query = "SELECT Date, SUM(KilosPlucked) as TotalKilos FROM HarvestRecords GROUP BY Date ORDER BY Date ASC LIMIT 7";
                dailyKilos.AddRange(new double[] { 45.5, 60.2, 55.0, 75.8, 68.4, 90.1, 85.3 });
                dateLabels.AddRange(new string[] { "06-04", "06-05", "06-06", "06-07", "06-08", "06-09", "06-10" });
                //data dekk add kra man meka graph ekla wadd balanna  
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dailyKilos.Add(Convert.ToDouble(reader["TotalKilos"]));
                            dateLabels.Add(reader["Date"].ToString());
                        }
                    }
                }
            }

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
            add_farmmer_1 add = new add_farmmer_1();
            add.Show();

            this.Hide();
        }
    }
}