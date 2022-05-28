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
    public partial class frm4 : Form
    {
        public frm4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Informe o nome!");
                txtNome.Focus();
                return;
            }

            if (txtCargo.Text == "")
            {
                MessageBox.Show("Informe o cargo!");
                txtCargo.Focus();
                return;
            }

            if (txtInscricao.Text == "")
            {
                MessageBox.Show("Informe o número de inscrição!");
                txtInscricao.Focus();
                return;
            }

            double prod = 0;
            double sal = 0;
            double grat = 0;

            if (!double.TryParse(txtProducao.Text, out prod))
            {
                MessageBox.Show("Informe um valor válido de produção");
                txtProducao.Focus();
                return;
            }

            if (!double.TryParse(txtSalario.Text, out sal))
            {
                MessageBox.Show("Informe um valor válido de salário");
                txtSalario.Focus();
                return;
            }

            if (!double.TryParse(txtGratificacao.Text, out grat))
            {
                MessageBox.Show("Informe um valor válido de gratificação");
                txtGratificacao.Focus();
                return;
            }

            double salBruto = 0;

            int b = 0;
            int c = 0;
            int d = 0;

            if (prod >= 150)
            {
                b = 1;
                c = 1;
                d = 1;
            }
            else if (prod >= 120)
            {
                b = 1;
                c = 1;
            }
            else if (prod >= 100)
            {
                b = 1;
            }

            salBruto = sal + sal * (0.05 * b + 0.1 * c + 0.1 * d) + grat;

            if (salBruto > 7000)
            {
                if (prod < 150 || grat == 0)
                {
                    salBruto = 7000;
                }
            }

            MessageBox.Show("Nome: " + txtNome.Text +
                            "\nCargo: " + txtCargo.Text +
                            "\nN inscrição: " + txtInscricao.Text +
                            "\nProdução: " + prod.ToString() +
                            "\nSalário: " + sal.ToString("N2") +
                            "\nGratificação: " + grat.ToString("N2") +
                            "\n\nSalário Bruto: " + salBruto.ToString("N2")
                );
        }
    }
}