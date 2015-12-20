using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string input = string.Empty;
        string operandLeft = string.Empty;
        string operandRight = string.Empty;
        char operation;
        double result = 0.0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            input += "1";
            this.textBox1.Text += input;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            input += "2";
            this.textBox1.Text += input;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            input += "3";
            this.textBox1.Text += input;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            input += "4";
            this.textBox1.Text = input;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            input += "5";
            this.textBox1.Text = input;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            input += "6";
            this.textBox1.Text = input;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            input += "7";
            this.textBox1.Text = input;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            input += "8";
            this.textBox1.Text = input;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            input += "9";
            this.textBox1.Text = input;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            input += "0";
            this.textBox1.Text = input;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
