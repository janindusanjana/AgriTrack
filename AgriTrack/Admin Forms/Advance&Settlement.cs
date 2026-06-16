using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgriTrack.Admin_Forms
{
    public partial class Advance_Settlement : Form
    {
        public Advance_Settlement()
        {
            InitializeComponent();
        }

        private void Advance_Settlement_Load(object sender, EventArgs e)
        {

        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            admindash dashboard = new admindash();
            dashboard.Show();

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Advance_Settlement advance_Settlement = new Advance_Settlement();
            advance_Settlement.Show();
            this.Hide();
        }
    }
}
