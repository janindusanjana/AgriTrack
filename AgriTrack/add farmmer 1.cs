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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void addfarmmer_Click(object sender, EventArgs e)
        {
            farmmer_add_form add = new farmmer_add_form();
            add.Show();

            this.Hide();
        }

        private void pnlColHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblSubTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblAppTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblSubTitle_Click_1(object sender, EventArgs e)
        {

        }

        private void lblColName_Click(object sender, EventArgs e)
        {

        }
    }
}
