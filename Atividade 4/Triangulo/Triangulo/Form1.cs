using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangulo
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtC.Clear();
            txtPerimetro.Clear();
            txtResult.Clear();
            
        }

        private void btnVerific_Click(object sender, EventArgs e)
        {
            double a, b, c, perimetro;
            string tipTriang;

            if (double.TryParse(txtA.Text, out a) && double.TryParse(txtB.Text, out b) &&
               double.TryParse(txtC.Text, out c))
            {
                if (a > 0 && b > 0 && c > 0)
                {
                    if (a > (b - c) && a < (b + c) && b > (a - c) && b < (a + c) && c > (a - b) && c < (a + b))
                    {
                        perimetro = a + b + c;
                        txtPerimetro.Text = perimetro.ToString();

                        if(a == b && b == c)
                        {
                            tipTriang = "Triângulo equilátero!";
                            txtResult.Text = tipTriang;
                        }

                        else if ((a != c && c == b) || (c != b && b == a) || (b != a && a == c))
                        {
                            tipTriang = "Triângulo isósceles!";
                            txtResult.Text = tipTriang;
                        }
                        else if(a != b && b != c)
                        {
                            tipTriang = "Triângulo escaleno!";
                            txtResult.Text = tipTriang;
                        }
                        else
                            MessageBox.Show("Valor Inválido!");
                    }
                    else
                        MessageBox.Show("Valor Inválido para ser triângulo!");
                }
                else
                    MessageBox.Show("Valor Inválido para ser triângulo!");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
