using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReajusteSalarial
{
    public partial class Form1 : Form
    {
        double salario;
        string nome, cat;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nome = txt_nome.Text;
            cat = txt_cat.Text;
            salario = double.Parse(txt_sal.Text);

            if (cat == "B" || cat == "D" || cat == "E" || cat == "I" || cat == "J" || cat == "J" || cat == "T")
            {
                salario = (15 * salario) / 100 + salario;
            }
            else if (cat == "R" || cat == "K")
            {
                salario = (25 * salario) / 100 + salario;
            }
            else if (cat == "L" || cat == "M" || cat == "N" || cat == "O" || cat== "P" || cat == "Q" || cat == "S")
            {
                salario = (35 * salario) / 100 + salario;
            }
            else
            {
                salario = (50 * salario) / 100 + salario;
            }
            txt_nome2.Text = Convert.ToString(nome);
            txt_cat2.Text = Convert.ToString(cat);
            txt_rj.Text = Convert.ToString(salario.ToString("C"));
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_cat.Clear();
            txt_cat2.Clear();
            txt_nome.Clear();
            txt_nome2.Clear();
            txt_sal.Clear();
            txt_rj.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
