using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade7
{
    public partial class frm2 : Form
    {
        public frm2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int num = 0;
            double calculo = 0;
            if (!int.TryParse(txtNumero.Text, out num))
            {
                MessageBox.Show("Informe um número inteiro!");
                txtNumero.Focus();
                return;
            }

            if (num == 0)
            {
                MessageBox.Show("Informe um número maior que zero!");
                txtNumero.Focus();
                return;
            }

            for (int i = 1; i <= num; i++)
            {
                calculo += 1 / (double)i;
            }

            MessageBox.Show("H = " + calculo.ToString("N2"));

        }
    }
}