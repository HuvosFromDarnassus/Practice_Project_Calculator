using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Practice_Project_Calculator
{
    public partial class Form_Logarithms : Form
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

        public Form_Logarithms()
        {
            InitializeComponent();
        }

        string operation(AANDB values)
        {
            if (values.A > 0 && values.B > 0)
                return Convert.ToString(Math.Log(values.A, values.B));

            return "A or B <= 0";
        }

        void showExceptionMessage() // Функция сообщения об ошибке
        {
            MessageBox.Show("Invalid input, try again");
        }

        private void Log_Button_Click(object sender, EventArgs e)
        {
            try
            {
                textBox3.Text = Convert.ToString(getValues().A);
                textBox4.Text = Convert.ToString(getValues().B);

                textBox5.Text = operation(getValues());
            }
            catch (Exception)
            {
                showExceptionMessage();
            }
        }
    }
}
