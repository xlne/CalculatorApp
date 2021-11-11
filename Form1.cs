using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double firstNumber;
        string operation;
        private bool equalButtonClicked = false;

        private void Btn1_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" && textBox.Text != null)
            {
                textBox.Text = "1";
            }
            else
            {
                textBox.Text = textBox.Text + "1";
            }
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" && textBox.Text != null)
            {
                textBox.Text = "2";
            }
            else
            {
                textBox.Text = textBox.Text + "2";
            }
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" && textBox.Text != null)
            {
                textBox.Text = "3";
            }
            else
            {
                textBox.Text = textBox.Text + "3";
            }
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" && textBox.Text != null)
            {
                textBox.Text = "4";
            }
            else
            {
                textBox.Text = textBox.Text + "4";
            }
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" && textBox.Text != null)
            {
                textBox.Text = "5";
            }
            else
            {
                textBox.Text = textBox.Text + "5";
            }
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" && textBox.Text != null)
            {
                textBox.Text = "6";
            }
            else
            {
                textBox.Text = textBox.Text + "6";
            }
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" && textBox.Text != null)
            {
                textBox.Text = "7";
            }
            else
            {
                textBox.Text = textBox.Text + "7";
            }
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" && textBox.Text != null)
            {
                textBox.Text = "8";
            }
            else
            {
                textBox.Text = textBox.Text + "8";
            }
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" && textBox.Text != null)
            {
                textBox.Text = "9";
            }
            else
            {
                textBox.Text = textBox.Text + "9";
            }
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "0" && textBox.Text != null)
            {
                textBox.Text = textBox.Text + "0";
            }            
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBox.Text);
            textBox.Text = "0";
            operation = "+";
        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBox.Text);
            textBox.Text = "0";
            operation = "-";
        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBox.Text);
            textBox.Text = "0";
            operation = "*";
        }

        private void BtnDivision_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBox.Text);
            textBox.Text = "0";
            operation = "/";
        }

        private void BtnEquals_Click(object sender, EventArgs e)
        {
            double secondNumber;
            double result;

            secondNumber = Convert.ToDouble(textBox.Text);

            if (operation == "+")
            {
                result = (firstNumber + secondNumber);
                textBox.Text = Convert.ToString(result);
                firstNumber = result;
            }
            if (operation == "-")
            {
                result = (firstNumber - secondNumber);
                textBox.Text = Convert.ToString(result);
                firstNumber = result;
            }
            if (operation == "*")
            {
                result = (firstNumber * secondNumber);
                textBox.Text = Convert.ToString(result);
                firstNumber = result;
            }
            if (operation == "/")
            {
                if (secondNumber == 0)
                {
                    textBox.Text = "Cannot divide by zero";
                }
                else
                {
                    result = (firstNumber / secondNumber);
                    textBox.Text = Convert.ToString(result);
                    firstNumber = result;
                }
            }
        }
        private void BtnNegate_Click(object sender, EventArgs e)
        {
            if (textBox.Text.StartsWith("-"))
            {
                textBox.Text = textBox.Text.Substring(1);
            }
            else if (!string.IsNullOrEmpty(textBox.Text) && double.Parse(textBox.Text) != 0)
            {
                textBox.Text = "-" + textBox.Text;
            }
        }

        private void BtnComma_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + ",";
        }

        private void BtnClearAll_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
        }

        private void BtnClearLastEntry_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
        }

        private void BtnFractions_Click(object sender, EventArgs e)
        {
            double text = Convert.ToDouble(textBox.Text);
            double result = 1 / text;
            textBox.Text = result.ToString(); 
        }

        private void BtnSqrt_Click(object sender, EventArgs e)
        {
            double text = Convert.ToDouble(textBox.Text);
            double result = Math.Sqrt(text);
            textBox.Text = result.ToString();
        }

        private void BtnSmile_Click(object sender, EventArgs e)
        {
            textBox.Text = "You are a great person! :)";
        }

        private void BtnBackspace_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
        }
    }
}
