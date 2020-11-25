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

        public Form_Menu()
        {
            InitializeComponent();
        }

        private void Buttom_Arythm_Op_Click(object sender, EventArgs e)
        {
            Form_A_Op.Show();
            this.Hide();
        }
    }
}
