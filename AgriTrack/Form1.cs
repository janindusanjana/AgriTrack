using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgriTrack;

namespace dashboard
{
    public partial class Dashboard : Form
    {
        public Dashboard(string role)
        {
            InitializeComponent();
            this.Text="AgriTrack - Logged in as: "+role;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            login lg = new login();

            lg.Show();

            this.Hide();
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void panel2_Click(object sender, EventArgs e)
        {


        }

        private void report_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Click(object sender, EventArgs e)
        {

        }

        private void Farmmer_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {
            Dashboard dash = new Dashboard();
            dash.Show();

        }
    }
}
