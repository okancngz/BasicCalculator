using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicCalculator
{
    public partial class Form1 : Form
    {
        public double firstNumber, secondNumber, Result;
        public string operation;
        public Form1()
        {
            InitializeComponent();
        }

        public void TextBoxValue(string value)
        {
            if (tbxCalculator.Text=="0" || tbxCalculator.Text==null)
            {
                tbxCalculator.Text = value;
            }
            else
            {
                tbxCalculator.Text = tbxCalculator.Text + value;
            }
        }
        public void Operation()
        {
            firstNumber = Convert.ToDouble(tbxCalculator.Text);
            tbxCalculator.Text = null;
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            TextBoxValue("0");
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            TextBoxValue("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            TextBoxValue("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            TextBoxValue("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            TextBoxValue("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            TextBoxValue("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            TextBoxValue("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            TextBoxValue("7");
        }

        

        private void btn8_Click(object sender, EventArgs e)
        {
            TextBoxValue("8");
        }

        

        private void btn9_Click(object sender, EventArgs e)
        {
            TextBoxValue("9");
        }

        

        private void btnVirgule_Click(object sender, EventArgs e)
        {
            tbxCalculator.Text = tbxCalculator.Text + ",";
        }

       

        private void btnPlus_Click(object sender, EventArgs e)
        {
            Operation();
            operation = "+";
        }

       

        private void btnMinus_Click(object sender, EventArgs e)
        {
            Operation();
            operation = "-";
        }

        

        private void btnMultipliedBy_Click(object sender, EventArgs e)
        {
            Operation();
            operation = "*";
        }

        

        private void btnDividedBy_Click(object sender, EventArgs e)
        {
            Operation();
            operation = "/";
        }

       

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxCalculator.Text = null;
        }
        private void btnEquals_Click(object sender, EventArgs e)
        {
            secondNumber = Convert.ToDouble(tbxCalculator.Text);
            if (operation=="+")
            {
                Result = firstNumber + secondNumber;
                tbxCalculator.Text = Convert.ToString(Result);
                Result = firstNumber;
            }
            if (operation == "-")
            {
                Result = firstNumber - secondNumber;
                tbxCalculator.Text = Convert.ToString(Result);
                Result = firstNumber;
            }
            if (operation == "*")
            {
                Result = firstNumber * secondNumber;
                tbxCalculator.Text = Convert.ToString(Result);
                Result = firstNumber;
            }

            try
            {
                if (operation == "/" && secondNumber!=0)
                {
                    Result = firstNumber / secondNumber;
                    tbxCalculator.Text = Convert.ToString(Result);
                    Result = firstNumber;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                throw;
            }
           
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            string data = tbxCalculator.Text;
            tbxCalculator.Text = "";
            for (int i = 0; i < data.Length - 1 ; i++)
            {
                tbxCalculator.Text += data[i].ToString();
            }
        }

    }
}
