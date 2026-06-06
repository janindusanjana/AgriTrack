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
    }
}
