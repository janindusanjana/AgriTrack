using AgriTrack.Admin_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgriTrack
{
    public partial class admindash : Form
    {
        public admindash()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Daily_Harvest daily_Harvest = new Daily_Harvest();
            daily_Harvest.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Advance_Settlement advance_Settlement = new Advance_Settlement();
            advance_Settlement.Show();
            this.Hide();
        }

        private void Settlment_Click(object sender, EventArgs e)
        {
            Advance_Settlement advance_Settlement = new Advance_Settlement();
            advance_Settlement.Show();
            this.Hide();
        }
    }
}
