using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Imposto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificarDesc_Click(object sender, EventArgs e)
        {
            string nome, aliqINSS, aliqIRRF, msg, estadoCivil, sexo;
            double salBruto, salFamilia, salLiquido, descINSS, descIRRF, salBase, parcelaIRRF, IRRF;
            int nFilho;

            if (double.TryParse(txtSalBruto.Text, out salBruto) && int.TryParse(txtFilho.Text, out nFilho))
            {
                nome = txtNome.Text;
                if (rbtnSexo1.Checked)
                    sexo = "Feminino";
                else
                    sexo = "Masculino";

                if(ckbxEstaCivil.Checked)
                    estadoCivil = "Casado";
                else
                    estadoCivil = "Solteiro";


                //Salario familia
                if (salBruto <= 1425.56)
                {
                    salFamilia = nFilho * 48;
                }
                else
                {
                    salFamilia = 0;
                }

                
                //descontos INSS
                if (salBruto <= 1045.00)
                {
                    aliqINSS = "7,5%";
                    descINSS = (0.075 * salBruto);
                }
                else if (salBruto > 1045.00 && salBruto <= 2089.60)
                {
                    aliqINSS = "9%";
                    descINSS = (0.09 * salBruto);
                }
                else if (salBruto > 2089.60 && salBruto <= 3134.40)
                {
                    aliqINSS = "12%";
                    descINSS = (0.12 * salBruto);
                }
                else if (salBruto > 3134.40 && salBruto <= 6101.06)
                {
                    aliqINSS = "14%";
                    descINSS = (0.14 * salBruto);
                }
                else
                {
                    aliqINSS = "Teto";
                    descINSS = 713.10;
                }


                // descontos IRRF
                salBase = salBruto - descINSS - (nFilho * 189.59);

                if (salBase <= 1903.98)
                {
                    aliqIRRF = "0%";
                    descIRRF = 0;
                    parcelaIRRF = 0;
                }
 
                else if (salBase > 1903.98 && salBase <= 2826.65)
                {
                    aliqIRRF = "7,5%";
                    descIRRF = (0.075 * salBase);
                    parcelaIRRF = 142.80;
                }

                else if (salBase > 2089.60 && salBase <= 3134.40)
                {
                    aliqIRRF = "15%";
                    descIRRF = (0.15 * salBase);
                    parcelaIRRF = 354.80;
                }

                else if (salBase > 3134.40 && salBase <= 6101.06)
                {
                    aliqIRRF = "22,5%";
                    descIRRF = (0.225 * salBase);
                    parcelaIRRF = 636.13;
                }

                else
                {
                    aliqIRRF = "27,5%";
                    descIRRF = (0.275 * salBase);
                    parcelaIRRF = 869.36;
                }

                IRRF = descIRRF - parcelaIRRF;
                salLiquido = (salBruto + salFamilia) - (descINSS + descIRRF);
                txtMsg.Text = nome;
                txtSalFamilia.Text = salFamilia.ToString("f2");
                txtAliqINSS.Text = aliqINSS;
                txtDescINSS.Text = descINSS.ToString("f2");
                txtDescIRRF.Text = IRRF.ToString("f2");
                txtAliqIRRF.Text = aliqIRRF;
                txtSalLiq.Text = salLiquido.ToString("f2");
                msg = $"Descontos do salário de {nome}, que é do sexo {sexo}, estado cívil {estadoCivil} ";
                txtMsg.Text = msg;
            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAliqINSS.Clear();
            txtAliqIRRF.Clear();
            txtDescINSS.Clear();
            txtDescIRRF.Clear();
            txtNome.Clear();
            txtSalFamilia.Clear();
            txtSalLiq.Clear();
            txtFilho.Clear();
            txtSalBruto.Clear();
            txtMsg.Clear();
        }

        private void lblSalLiq_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
