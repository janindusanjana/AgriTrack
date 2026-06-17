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
    public partial class farmmer_add_form : Form
    {
        public farmmer_add_form()
        {
            InitializeComponent();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void farmmer_add_form_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            string fullName = txtName.Text.Trim();
            string address = txtAddress.Text.Trim();
            string nic = txtNic.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string regDate = dtpJoinDate.Value.ToString("yyyy-MM-dd"); 

        
            string gender = "";
            if (radioMale.Checked)
            {
                gender = "Male";
            }
            else if (radioFemale.Checked)
            {
                gender = "Female";
            }

           
            if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(nic) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(gender))
            {
                MessageBox.Show("Please fill in all mandatory fields!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            try
            {
                string connectionString = "Data Source=" + System.IO.Path.Combine(Application.StartupPath, "AgriTrackDB.db") + ";";

                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();

                    string query = @"INSERT INTO Worker (Name, Address, NIC, Phone, Gender, JoinDate) 
                             VALUES (@FullName, @Address, @NIC, @Phone, @Gender, @RegDate)";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FullName", fullName);
                        cmd.Parameters.AddWithValue("@Address", address);
                        cmd.Parameters.AddWithValue("@NIC", nic);
                        cmd.Parameters.AddWithValue("@Phone", phone);
                        cmd.Parameters.AddWithValue("@Gender", gender);
                        cmd.Parameters.AddWithValue("@RegDate", regDate);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Worker registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearForm(); 
                        }
                        else
                        {
                            MessageBox.Show("Failed to register worker. Please try again.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        private void ClearForm()
        {
            txtName.Clear();
            txtAddress.Clear();
            txtNic.Clear();
            txtPhone.Clear();
            radioMale.Checked = false;
            radioFemale.Checked = false;
            dtpJoinDate.Value = DateTime.Now;

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}
