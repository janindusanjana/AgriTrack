using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgriTrack
{
    public partial class add_farmmer_1 : Form
    {
        public add_farmmer_1()
        {
            InitializeComponent();
        }



        private void addfarmmer_Click(object sender, EventArgs e)
        {
            farmmer_add_form add = new farmmer_add_form();
            add.Show();

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DailyHarvestAdding daily = new DailyHarvestAdding();
            daily.Show();

            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Advance advanced = new Advance();
            advanced.Show();

            this.Hide();
        }

        private void Settlment_Click(object sender, EventArgs e)
        {
            Settlement_UI settlement_UI = new Settlement_UI();

            settlement_UI.Show();

            this.Hide();
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            dashboard1 dashboard1 = new dashboard1();
            dashboard1.Show();

            this.Hide();
        }
    }
}
