using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Practice_Project_Calculator
{
    public partial class Form_Trigonometric_Functions : Form
    {
        struct AANDB // Структура чисел
        {
            public double A;
            public double B;
        }

        AANDB getValues() // Функция получения значений с полей
        {
            AANDB values;

            values.A = Convert.ToDouble(textBox1.Text);
            values.B = Convert.ToDouble(textBox2.Text);

            return values;
        }

        string operation(AANDB values, string op) // Функция математических операций
        {
            switch (op)
            {
                case "sin":
                    return Convert.ToString(Math.Round(Math.Sin(values.A), 2)) + " | "
                    + Convert.ToString(Math.Round(Math.Sin(values.B), 2));
                case "cos":
                    return Convert.ToString(Math.Round(Math.Cos(values.A), 2)) + " | "
                    + Convert.ToString(Math.Round(Math.Cos(values.B), 2));
                case "tan":
                    return Convert.ToString(Math.Round(Math.Tan(values.A), 2)) + " | "
                    + Convert.ToString(Math.Round(Math.Tan(values.B), 2));
                case "ctan":
                    return Convert.ToString(Math.Round(1 / Math.Tan(values.A), 2)) + " | "
                    + Convert.ToString(Math.Round(1 / Math.Tan(values.B), 2));

            }

            return Convert.ToString(values.A + values.B);
        }

        void showExceptionMessage() // Функция сообщения об ошибке
        {
            MessageBox.Show("Invalid input, try again");
        }

        public Form_Trigonometric_Functions()
        {
            InitializeComponent();
        }

        private void Sin_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                textBox3.Text = operation(getValues(), "sin");
            }
            catch (Exception)
            {
                showExceptionMessage();
            }
        }

        private void Cos_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                textBox3.Text = operation(getValues(), "cos");
            }
            catch (Exception)
            {
                showExceptionMessage();
            }
        }

        private void Tan_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                textBox3.Text = operation(getValues(), "tan");
            }
            catch (Exception)
            {
                showExceptionMessage();
            }
        }

        private void Ctan_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                textBox3.Text = operation(getValues(), "ctan");
            }
            catch (Exception)
            {
                showExceptionMessage();
            }
        }
    }
}
