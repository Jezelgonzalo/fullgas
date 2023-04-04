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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int number = 1;
            textBox1.Text += number.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int number = 2;
            textBox1.Text += number.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int number = 3;
            textBox1.Text += number.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number = 4;
            textBox1.Text += number.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int number = 5;
            textBox1.Text += number.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int number = 6;
            textBox1.Text += number.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int number = 7;
            textBox1.Text += number.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int number = 8;
            textBox1.Text += number.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int number = 9;
            textBox1.Text += number.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int number = 0;
            textBox1.Text += number.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text.ToString();
            double liter;
            double price = 50.30;
            double amount;


            liter = Convert.ToDouble(textBox2.Text);
            amount = liter * price;
            textBox3.Text = amount.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.ShowDialog();

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            this.Hide();
            form6.ShowDialog();

        }
    }
}
