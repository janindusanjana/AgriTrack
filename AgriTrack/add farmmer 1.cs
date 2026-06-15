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

            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DailyHarvestAdding adding = new DailyHarvestAdding();
            adding.Show();
            this.Hide();
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            dashboard1 add2 = new dashboard1();
            add2.Show();

            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Advance add3 = new Advance();
            add3.Show();

            this.Hide();
        }


   
        

            

        private void Settlment_Click(object sender, EventArgs e)
        {
            Settlement_UI add4 = new Settlement_UI();
            add4.Show();

            this.Hide();
        }
    }
    }

