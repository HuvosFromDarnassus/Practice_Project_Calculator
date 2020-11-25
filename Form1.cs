using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_Project_Calculator
{
    public partial class Form_Menu : Form
    {
        Form_Arythmetic_Operations Form_A_Op = new Form_Arythmetic_Operations();
        Form_Trigonometric_Functions Form_Trigon_Func = new Form_Trigonometric_Functions();

        public Form_Menu()
        {
            InitializeComponent();
        }

        private void Buttom_Arythm_Op_Click(object sender, EventArgs e)
        {
            Form_A_Op.Show();
            this.Hide();
        }

        private void Button_Trigon_Func_Click(object sender, EventArgs e)
        {
            Form_Trigon_Func.Show();
            this.Hide();
        }
    }
}

//TODO:
//6) Добавить факториал в базовый калькулятор
//7) Сделать калькулятор логарифмов
//8) Сделать вывод графика в тригонометрических функциях
