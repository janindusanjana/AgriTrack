using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace AgriTrack.Admin_Forms
{
    public partial class Advance_Settlement : Form
    {
       
        private string connectionString = @"data source=C:\Users\wwwja\Desktop\AgriTrack\AgriTrackDB.db;";

        public Advance_Settlement()
        {
            InitializeComponent();

            
            btnLoadAdvanceReport.Click += BtnLoadAdvanceReport_Click;
            btnUpdateSettlemet.Click += BtnUpdateSettlemet_Click;
        }

        private void Advance_Settlement_Load(object sender, EventArgs e)
        {
            
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "MM/yyyy";
            dateTimePicker2.ShowUpDown = true;
        }

        private void BtnLoadAdvanceReport_Click(object sender, EventArgs e)
        {
            
            dataGridView1.Rows.Clear();

            
            string selectedMonth = dateTimePicker2.Value.ToString("MM/yyyy");

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

          
            using (SqliteConnection conn = new SqliteConnection(connectionString))
            {
               
                using (SqliteCommand cmd = new SqliteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@SalaryMonth", selectedMonth);

                    try
                    {
                        conn.Open();
                        
                        using (SqliteDataReader reader = cmd.ExecuteReader())
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

            string selectedMonth = dateTimePicker2.Value.ToString("MM/yyyy");

            string updateQuery = @"
                UPDATE SalarySettlement 
                SET IsPaid = @IsPaid 
                WHERE WorkerID = @WorkerID AND SalaryMonth = @SalaryMonth";

            using (SqliteConnection conn = new SqliteConnection(connectionString))
            {
                try
                {
                    conn.Open();

                   
                    using (SqliteTransaction transaction = conn.BeginTransaction())
                    {
                        
                        using (SqliteCommand cmd = new SqliteCommand(updateQuery, conn))
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
    }
}