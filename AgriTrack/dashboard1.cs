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


            //data add kra graph eka wdd balanna

            dailyKilos.AddRange(new double[] { 55.2, 68.4, 62.0, 85.3, 78.1, 92.6, 88.5 });
            dateLabels.AddRange(new string[] { "06-11", "06-12", "06-13", "06-14", "06-15", "06-16", "06-17" });
           
            //database ek connect krma auto data tika ganna
            try
            {
                conn.Open();
                string query = "SELECT Date, SUM(KilosPlucked) as TotalKilos FROM HarvestRecords GROUP BY Date ORDER BY Date ASC LIMIT 7";
                dailyKilos.AddRange(new double[] { 45.5, 60.2, 55.0, 75.8, 68.4, 90.1, 85.3 });
                dateLabels.AddRange(new string[] { "06-04", "06-05", "06-06", "06-07", "06-08", "06-09", "06-10" });
                //data dekk add kra man meka graph ekla wadd balanna  
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    conn.Open();

                    string query = "SELECT HarvestDate, SUM(TeaKg) as TotalKilos FROM Harvest GROUP BY HarvestDate ORDER BY HarvestDate ASC LIMIT 7";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
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

        }
    }
}