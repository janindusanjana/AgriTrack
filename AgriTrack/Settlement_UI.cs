using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgriTrack
{
    public partial class Settlement_UI : Form
    {
        public Settlement_UI()
        {
            InitializeComponent();
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            dashboard1 dashboard = new dashboard1();
            dashboard.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            add_farmmer_1 add_farmer_1 = new add_farmmer_1();
            add_farmer_1.Show();

            this.Show();
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
    }
}
