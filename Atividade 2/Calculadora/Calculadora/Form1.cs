using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        double n1, n2, resultado;
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblVal2_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // todos são modos de limpar os componentes.
            txtVal1.Text = "";
            txtVal2.Clear();
            txtResult.Text = string.Empty; // ou tambem txtResult.Texte = null;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtVal1.Text, out n1) &&
               double.TryParse(txtVal2.Text, out n2))
            {

                resultado = n1 - n2;
                txtResult.Text = resultado.ToString();
            }
            else
                MessageBox.Show("Valores invalidos!");
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtVal1.Text, out n1) &&
               double.TryParse(txtVal2.Text, out n2))
            {
                if (n2 == 0)
                    MessageBox.Show("Valor invalido!");
                else
                {
                    resultado = n1 / n2;
                    txtResult.Text = resultado.ToString();
                }
            }
            else
                MessageBox.Show("Valores invalidos!");
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtVal1.Text, out n1) &&
               double.TryParse(txtVal2.Text, out n2))
            {

                resultado = n1 * n2;
                txtResult.Text = resultado.ToString();
            }
            else
                MessageBox.Show("Valores invalidos!");
        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
           

            if(double.TryParse(txtVal1.Text,out n1) && 
                double.TryParse(txtVal2.Text,out n2))
            {
                
                resultado = n1 + n2;
                txtResult.Text = resultado.ToString();
            }
            else
                MessageBox.Show("Valores invalidos!");

        }
    }
}
