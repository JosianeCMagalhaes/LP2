using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P0030482013048
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            double[,] vendas = new double[8, 4];
            string aux = "";
            double totalMes, totalSemana = 0, totalGeral = 0;

            for (var i = 0; i < 8; i++)
            {
                totalMes = 0;
                for (var j = 0; j < 4; j++)
                {
                    aux = Interaction.InputBox("Total do mês: " + (i + 1).ToString() + " Semana: " + (j + 1).ToString(),
                        "Entrada de dados");

                    if (double.TryParse(aux, out vendas[i, j]) &&
                        (vendas[i, j] >= 0))
                    {
                        totalSemana = vendas[i, j];
                        lstTotal.Items.Add("Total do Mês: " + (i + 1) + " Semana: " + (j + 1) + " " +
                            totalSemana.ToString("C2", CultureInfo.CurrentCulture));
                    }
                    else
                    {
                        MessageBox.Show("Valor inválido!!");
                        j--;
                    }
                    totalMes += totalSemana;
                }
                totalGeral += totalMes;

                lstTotal.Items.Add("Total Mês = " + totalMes.ToString("C2", CultureInfo.CurrentCulture));
                lstTotal.Items.Add("............................");
            }
            lstTotal.Items.Add("Total Geral = " + totalGeral.ToString("C2", CultureInfo.CurrentCulture));
        }
    }
}