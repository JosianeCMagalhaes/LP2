using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Atividade8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[20];
            string auxiliar = "";

            for (int i = 0; i < vetor.Length; i++)
            {
                auxiliar = Interaction.InputBox("Digite o número " + (i + 1).ToString() + ": ");

                if (!(int.TryParse(auxiliar, out vetor[i])))
                {
                    MessageBox.Show("Número inválido!");
                    i--;
                }
            }

            auxiliar = "";

            for (int i = vetor.Length - 1; i > 0; i--)
            {
                auxiliar += vetor[i].ToString() + "\n";
            }

            MessageBox.Show(auxiliar);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[20];
            string auxiliar = "";

            for (int i = 0; i < vetor.Length; i++)
            {
                auxiliar = Interaction.InputBox("Digite o número " + (i + 1).ToString() + ": ");

                if (!(int.TryParse(auxiliar, out vetor[i])))
                {
                    MessageBox.Show("Número inválido!");
                    i--;
                }
            }

            Array.Reverse(vetor);

            auxiliar = "";

            for (int i = 0; i < vetor.Length; i++)
            {
                auxiliar += vetor[i].ToString() + "\n";
            }

            MessageBox.Show(auxiliar);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            double[] qtd = new double[10];
            double[] valor = new double[10];

            bool qtdOk = false;

            string auxiliar = "";

            for (int i = 0; i < qtd.Length; i++)
            {
                if (!qtdOk)
                {
                    auxiliar = Interaction.InputBox("Digite a quantidade do produto " + (i + 1).ToString() + ": ");

                    if (!(double.TryParse(auxiliar, out qtd[i])))
                    {
                        MessageBox.Show("Quantidade inválida!");
                        i--;
                    }
                    else
                    {
                        qtdOk = true;
                    }
                }

                auxiliar = Interaction.InputBox("Digite o valor do produto " + (i + 1).ToString() + ": ");

                if (!(double.TryParse(auxiliar, out valor[i])))
                {
                    MessageBox.Show("Valor inválido!");
                    i--;
                }
                else
                {
                    qtdOk = false;
                }
            }

            double faturamento = 0;

            for (int i = 0; i < qtd.Length; i++)
            {
                faturamento += qtd[i] * valor[i];
            }

            MessageBox.Show("Faturamento do mês: R$ " + faturamento.ToString("N2"));
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            string[] Alunos = { "Viviane", "André", "Hélio", "Denise", "Junior", "Leonardo", "Jose", "Nelma", "Tobby" };

            int total = 0;

            for (int i = 0; i < Alunos.Length - 1; i++)
            {
                total += Alunos[i].Length;
            }

            MessageBox.Show(total.ToString());
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            ArrayList arr = new ArrayList();

            arr.Add("Ana");
            arr.Add("André");
            arr.Add("Débora");
            arr.Add("Fátima");
            arr.Add("João");
            arr.Add("Janete");
            arr.Add("Otávio");
            arr.Add("Marcelo");
            arr.Add("Pedro");
            arr.Add("Thais");

            arr.Remove("Otávio");

            string texto = "";

            for (int i = 0; i < arr.Count; i++)
            {
                texto += arr[i] + "\n";
            }

            MessageBox.Show(texto);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            double[,] notas = new double[20, 3];

            string auxiliar = "";

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    auxiliar = Interaction.InputBox("Digite a nota " + (j + 1).ToString() + " do aluno " + (i + 1).ToString());

                    if (!(double.TryParse(auxiliar, out notas[i, j])))
                    {
                        MessageBox.Show("Valor de nota inválido!");
                        j--;
                    }
                }
            }

            auxiliar = "";

            for (int i = 0; i < 20; i++)
            {
                auxiliar += "Aluno " + (i + 1).ToString() + ": média " + ((notas[i, 0] + notas[i, 1] + notas[i, 2]) / 3).ToString("N2") + "\n";
            }

            MessageBox.Show(auxiliar);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frm2"];

            if (fc != null)
            {
                fc.Close();
            }

            frm2 frm = new frm2();
            frm.Show();
        }
    }
}