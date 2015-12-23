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
        protected string operandLeft = string.Empty;
        protected string operandRight = string.Empty;
        protected string operation = string.Empty;
        protected double result = 0.0;
        
        public Form1()
        {
            InitializeComponent();
        }

        protected void calculate()
        {
            result = double.Parse(operandLeft) * double.Parse(operandRight);
        }

        protected void handleCalculation()
        {
            operandRight = this.textBox1.Text;
            calculate();
            operandLeft = result.ToString();
            operandRight = string.Empty;
            this.textBox1.Text = result.ToString();
        }

        internal static string getTagValueFromButton(object sender)
        {
            Button button = sender as Button;

            if (button != null)
                return button.Tag.ToString();

            throw new ArgumentException("Unexpected sender");
        }


        #region button handlers
        #region input buttons

        private void operandInputButton_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += getTagValueFromButton(sender);
        }

        #endregion

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        #region operator buttons
        //multiplication
        private void button14_Click(object sender, EventArgs e)
        {
            if (operandLeft == string.Empty)
            {
                operandLeft = this.textBox1.Text;
                this.textBox1.Text = string.Empty;
            }
                
            else
            {
                handleCalculation();
            }
                
            
            //what if user has typed two operands in a sequence?
            operation = "*";
        }

        //adding
        private void button15_Click(object sender, EventArgs e)
        {

        }

        //dividing
        private void button18_Click(object sender, EventArgs e)
        {

        }

        //substracting
        private void button19_Click(object sender, EventArgs e)
        {

        }

        //calculating
        private void button20_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }
        #endregion button handlers

    }
}
