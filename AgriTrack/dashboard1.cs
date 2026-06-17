using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;
using System.Data.SQLite;
using AgriTrack.Admin_Forms;

namespace AgriTrack
{
    public partial class dashboard1 : Form
    {

        string connectionString = "Data Source=" + System.IO.Path.Combine(Application.StartupPath, "AgriTrackDB.db") + ";";

        public dashboard1()
        {
            InitializeComponent();
            
        }

        private void dashboard1_Load(object sender, EventArgs e)
        {
            LoadDashboardTotals();
            LoadHarvestChart();
        }

        private void LoadDashboardTotals()
        {
            
            string currentMonthPattern = DateTime.Now.ToString("yyyy-MM") + "%";

            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();

                   
                    string harvestQuery = "SELECT SUM(TeaKg) FROM Harvest WHERE HarvestDate LIKE @monthPattern";
                    using (SQLiteCommand cmd = new SQLiteCommand(harvestQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@monthPattern", currentMonthPattern);
                        object result = cmd.ExecuteScalar();
                        tbxTotalHarvest.Text = (result != DBNull.Value && result != null)
                                               ? Convert.ToDouble(result).ToString("0.00") + " Kg"
                                               : "0.00 Kg";
                    }

                   
                    string advanceQuery = "SELECT SUM(Amount) FROM Advance WHERE AdvanceDate LIKE @monthPattern";
                    using (SQLiteCommand cmd = new SQLiteCommand(advanceQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@monthPattern", currentMonthPattern);
                        object result = cmd.ExecuteScalar();
                        tbxGivenAdvance.Text = (result != DBNull.Value && result != null)
                                               ? "Rs " + Convert.ToDouble(result).ToString("0.00")
                                               : "Rs 0.00";
                    }

                   
                    string workerQuery = "SELECT COUNT(DISTINCT WorkerID) FROM Harvest WHERE HarvestDate LIKE @monthPattern";
                    using (SQLiteCommand cmd = new SQLiteCommand(workerQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@monthPattern", currentMonthPattern);
                        object result = cmd.ExecuteScalar();
                        tbxActiveWorkers.Text = (result != DBNull.Value && result != null)
                                                ? result.ToString()
                                                : "0";
                    }

                    
                    textBox1.Text = "Rs 50.00";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dashboard totals: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadHarvestChart()
        {
            LiveCharts.WinForms.CartesianChart harvestChart = new LiveCharts.WinForms.CartesianChart();
            harvestChart.Dock = DockStyle.Fill;
            panelChartContainer.Controls.Clear();
            panelChartContainer.Controls.Add(harvestChart);

            ChartValues<double> dailyKilos = new ChartValues<double>();
            List<string> dateLabels = new List<string>();

            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                   
                    string query = "SELECT HarvestDate, SUM(TeaKg) as TotalKilos FROM Harvest GROUP BY HarvestDate ORDER BY HarvestDate DESC LIMIT 7";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            
                            List<double> tempKilos = new List<double>();
                            List<string> tempDates = new List<string>();

                            while (reader.Read())
                            {
                                tempKilos.Add(Convert.ToDouble(reader["TotalKilos"]));
                                tempDates.Add(reader["HarvestDate"].ToString());
                            }

                            
                            tempKilos.Reverse();
                            tempDates.Reverse();

                            dailyKilos.AddRange(tempKilos);
                            dateLabels.AddRange(tempDates);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading chart data: " + ex.Message, "Chart Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
            if (dailyKilos.Count == 0)
            {
                dailyKilos.AddRange(new double[] { 0, 0, 0, 0, 0, 0, 0 });
                dateLabels.AddRange(new string[] { "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A" });
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
            add_farmmer_1 add_farmer_1 = new add_farmmer_1();
            add_farmer_1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Userdata.Role == "Admin")
            {
              
                Daily_Harvest adminSet = new Daily_Harvest();
                adminSet.Show();
                this.Hide();
            }
            else if (Userdata.Role == "User")
            {
                DailyHarvestAdding dailyHarvestAdding = new DailyHarvestAdding();
            dailyHarvestAdding.Show();
            this.Hide();
        }

        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (Userdata.Role == "Admin")
            {
                
                Advance_Settlement adminAdv = new Advance_Settlement();
                adminAdv.Show();
                this.Hide();
            }

            else if (Userdata.Role == "User")
            {
                Advance advance = new Advance();
                advance.Show();
                this.Hide();
            }
        }

        private void Settlment_Click(object sender, EventArgs e)
        {
            if (Userdata.Role == "Admin")
            {
               
                Advance_Settlement adminSet = new Advance_Settlement();
                adminSet.Show();
                this.Hide();
            }
            else if (Userdata.Role == "User")
            {
                Settlement_UI settlement_UI = new Settlement_UI();
                settlement_UI.Show();
                this.Hide();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Opensc login = new Opensc();
            login.Show();
            this.Hide();
        }
    }
}