using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade8
{
    public partial class frm2 : Form
    {
        public frm2()
        {
            InitializeComponent();
        }

        private void btnExec_Click(object sender, EventArgs e)
        {
            string[] nomes = new string[10];
            int[] qtdChar = new int[10];
            string auxiliar = "";

            for (int i = 0; i < nomes.Length; i++)
            {
                auxiliar = Interaction.InputBox("Digite " + (i + 1).ToString() + "º nome completo:");

                if (auxiliar != "")
                {
                    nomes[i] = auxiliar;
                    auxiliar = nomes[i].Replace(" ", "");
                    qtdChar[i] = auxiliar.Length;

                    listView1.Items.Add("O nome " + nomes[i] + " tem " + qtdChar[i] + " caracteres.");
                }
                else
                {
                    MessageBox.Show("Nome não pode estar em branco!");
                    i--;
                }
            }
        }
    }
}