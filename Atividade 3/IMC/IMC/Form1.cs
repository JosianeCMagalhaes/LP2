using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            mskbxAltura.Clear();
            mskbxPeso.Clear();
            mskbxResult.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double altura, peso, resultado;

            if (rbtnFem.Checked)
            {
                if(double.TryParse(mskbxAltura.Text, out altura) &&
                double.TryParse(mskbxPeso.Text, out peso)) 
                {
                    resultado = (62.1 * altura) - 44.7;
                    mskbxResult.Text = resultado.ToString();
                    if (peso > resultado)
                        MessageBox.Show("Está um pouco acima do seu peso ideal!");
                    else if (peso == resultado)
                        MessageBox.Show("Está no peso ideal!");
                    else
                        MessageBox.Show("Está um pouco abaixo do seu peso ideal!");
                }

            }
            else
            {
                if (double.TryParse(mskbxAltura.Text, out altura) &&
                double.TryParse(mskbxPeso.Text, out peso))
                {
                    resultado = (72.7 * altura) - 58;
                    mskbxResult.Text = resultado.ToString();
                    if (peso > resultado)
                        MessageBox.Show("Está um pouco acima do seu peso ideal!");
                    else if(peso == resultado)
                        MessageBox.Show("Está no peso ideal!");
                    else
                        MessageBox.Show("Está um pouco abaixo do seu peso ideal!");
                }


            }

        }
    }
}
