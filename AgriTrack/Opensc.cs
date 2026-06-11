using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgriTrack
{
    public partial class Opensc : Form
    {
        public Opensc()
        {
            InitializeComponent();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlBody_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnWorker_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pnlWorkerLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnWorker_Click_1(object sender, EventArgs e)
        {
            pnlWorker.Visible = false;      
            pnlWorkerLogin.Visible = true;  
            pnlWorkerLogin.BringToFront();  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlWorkerLogin.Visible = false; 
            pnlWorker.Visible = true;      
        }

        private void lblChoose_Click(object sender, EventArgs e)
        {

        }

        private void pnlBody_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Opensc_Load(object sender, EventArgs e)
        {
            pnlWorkerLogin.Visible = false;
            pnlAdminLogin.Visible = false;
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            pnlAdmin.Visible = false; 
            pnlAdminLogin.Visible = true;  
            pnlAdminLogin.BringToFront();  
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pnlAdminLogin.Visible = false; 
            pnlAdmin.Visible = true;       
        }
    }
}
