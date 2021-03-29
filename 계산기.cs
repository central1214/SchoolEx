using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0329
{
    public partial class Form1 : Form
    {
        string flag = "";
        string stock = "";
        public Form1()
        {
            InitializeComponent();
            label1.Text = "";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            label1.Text += "0";
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            flag = "+";
            stock = label1.Text;
            label1.Text = stock + flag;
        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
            flag = "-";
            stock = label1.Text;
            label1.Text = stock + flag;
        }

        private void buttonMulti_Click(object sender, EventArgs e)
        {
            flag = "×";
            stock = label1.Text;
            label1.Text = stock + flag;
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            if (flag == "+")
            {
                label1.Text = (double.Parse(stock) + double.Parse(label1.Text)).ToString("0.00");
            }
            else if (flag == "-")
            {
                label1.Text = (double.Parse(stock) + double.Parse(label1.Text)).ToString("0.00");
            }
            else if (flag == "×")
            {
                label1.Text = (double.Parse(stock) + double.Parse(label1.Text)).ToString("0.00");
            }
            else
            {
            }
            flag = "";
            stock = label1.Text;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            stock = "";
            label1.Text = "";
            flag = "";
        }

        private void buttonComma_Click(object sender, EventArgs e)
        {

        }
    }
}
