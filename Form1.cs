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
        Form_Logarithms Form_Log = new Form_Logarithms();

        public Form_Menu()
        {
            InitializeComponent();
        }

        private void Buttom_Arythm_Op_Click(object sender, EventArgs e)
        {
            Form_A_Op.Show();
        }

        private void Button_Trigon_Func_Click(object sender, EventArgs e)
        {
            Form_Trigon_Func.Show();
        }

        private void Button_Logarithms_Click(object sender, EventArgs e)
        {
            Form_Log.Show();
        }
    }
}

//TODO:
//8) Сделать вывод графика в тригонометрических функциях
//10) Слинковать exe
