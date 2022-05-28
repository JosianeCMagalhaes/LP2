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
    public partial class frm3 : Form
    {
        public frm3()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (txtFrase.Text.Length < 1)
            {
                MessageBox.Show("Digite alguma palavra ou frase!");
                txtFrase.Focus();
                return;
            }

            string texto1 = txtFrase.Text.ToUpper().Replace(" ", "");

            char[] arr = texto1.ToCharArray();

            Array.Reverse(arr);

            string texto2 = new string(arr);

            if (texto1.ToUpper().Replace(" ", "") == texto2)
            {
                MessageBox.Show(texto2 + "\n É um palíndromo!");
            }
            else
            {
                MessageBox.Show(texto2 + "\n Não é um palíndromo!");
            }
        }
    }
}