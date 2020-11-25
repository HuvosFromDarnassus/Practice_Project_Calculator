using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Practice_Project_Calculator
{
    public partial class Form_Arythmetic_Operations : Form
    {
        string input = string.Empty;
        string firstOperand = string.Empty;
        string secondOperand = string.Empty;
        char operation;
        double result = 0.0;

        public Form_Arythmetic_Operations()
        {
            InitializeComponent();
        }

        private void Zero_Btn_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "0";
            this.textBox1.Text += input;
        }

        private void One_Btn_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "1";
            this.textBox1.Text += input;
        }

        private void Two_Btn_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "2";
            this.textBox1.Text += input;
        }

        private void Three_Btn_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "3";
            this.textBox1.Text += input;
        }

        private void Four_Btn_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "4";
            this.textBox1.Text += input;
        }

        private void Five_Btn_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "5";
            this.textBox1.Text += input;
        }

        private void Six_Btn_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "6";
            this.textBox1.Text += input;
        }

        private void Seven_Btn_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "7";
            this.textBox1.Text += input;
        }

        private void Eight_Btn_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "8";
            this.textBox1.Text += input;
        }

        private void Nine_Btn_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "9";
            this.textBox1.Text += input;
        }

        private void Div_Btn_Click(object sender, EventArgs e)
        {
            firstOperand = input;
            operation = '/';
            input = string.Empty;
        }

        private void Multi_Btn_Click(object sender, EventArgs e)
        {
            firstOperand = input;
            operation = '*';
            input = string.Empty;
        }

        private void Plus_Btn_Click(object sender, EventArgs e)
        {
            firstOperand = input;
            operation = '+';
            input = string.Empty;
        }

        private void Minus_Btn_Click(object sender, EventArgs e)
        {
            firstOperand = input;
            operation = '-';
            input = string.Empty;
        }

        private void Del_Btn_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.input = string.Empty;
            this.firstOperand = string.Empty;
            this.secondOperand = string.Empty;
        }

        private void Equals_Button_Click(object sender, EventArgs e)
        {
            secondOperand = input;
            double num1, num2;
            double.TryParse(firstOperand, out num1);
            double.TryParse(secondOperand, out num2);

            if (operation == '+')
            {
                result = num1 + num2;
                textBox1.Text = result.ToString();
            }
            else if (operation == '-')
            {
                result = num1 - num2;
                textBox1.Text = result.ToString();
            }
            else if (operation == '*')
            {
                result = num1 * num2;
                textBox1.Text = result.ToString();
            }
            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    textBox1.Text = result.ToString();
                }
                else
                {
                    textBox1.Text = "Zero divide error!";
                }

            }
        }
    }
}
