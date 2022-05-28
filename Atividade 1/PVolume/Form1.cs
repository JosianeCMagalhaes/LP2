using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVolume
{
    public partial class frPrincipal : Form
    {
        public frPrincipal()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void rbRaio_Click(object sender, EventArgs e)
        {
          
        }

        private void rbRaio_CheckedChanged(object sender, EventArgs e)
        {
            lbEntrada.Text = "Raio";
            lbSaida.Text = "Diametro";
            tbRaio.Text = "";
        }

        private void rbDiametro_CheckedChanged(object sender, EventArgs e)
        {
            lbSaida.Text = "Raio";
            lbEntrada.Text = "Diametro";
        }

        private void tbRaio_TextChanged(object sender, EventArgs e)
        {
            double raio = 0, resultado = 0, diametro = 0;
            if (tbRaio.Text != "")
            {
                if (rbRaio.Checked)
                {
                    double.TryParse(tbRaio.Text, out raio);
                    diametro = 2 * raio;
                    textBox1.Text = diametro.ToString();
                }
                if (rbDiametro.Checked)
                {
                    double.TryParse(tbRaio.Text, out diametro);
                    raio = diametro / 2;
                    textBox1.Text = raio.ToString();
                }

                resultado = Math.PI * Math.Pow(raio, 2);

                tbResultado.Text = resultado.ToString("N2");
            }
            else
            {
                textBox1.Text = "";
                tbResultado.Text = "";

            }
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            tbRaio.Text = "";
           
            tbResultado.Text = "";
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbDiametro_TextChanged(object sender, EventArgs e)
        {
            double raio = 0, resultado = 0, diametro = 0;

            if (rbRaio.Checked)
            {
                diametro = 2 * raio;
            }

            if (rbDiametro.Checked)
            {
                raio = diametro / 2;
                tbRaio.Text = raio.ToString();
            }
            resultado = Math.PI * Math.Pow(raio, 2);

            tbResultado.Text = resultado.ToString();
        }

        private void tbRaio_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void frPrincipal_Load(object sender, EventArgs e)
        {
            lbEntrada.Text = "Raio";
            lbSaida.Text = "Diametro";
            tbRaio.Text = "";
        }

        private void lbResultado_Click(object sender, EventArgs e)
        {

        }

        private void brCalcular_Click(object sender, EventArgs e)
        {

        }
    }
}
