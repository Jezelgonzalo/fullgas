using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fullgas
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbprogress.Text = (pbloading.Value + "%");

            if (pbloading.Value < 100 ) 
            {
                pbloading.Value += 5;
                lblstatementprogress.Text = "Filling up your tank...";
            }
            else
            {
                lbstatementprog.Text = "Your tank has been filled!";
                timer1.Stop();
                Form8 frm = new Form8();
                this.Hide();
                frm.ShowDialog();

            }
        }

        private void lblstatementprogress_Click(object sender, EventArgs e)
        {

        }

        private void lbprogress_Click(object sender, EventArgs e)
        {

        }
    }
}
