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
    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();
        }

        private void btEspaco_Click(object sender, EventArgs e)
        {
            int qtd = 0;

            for (int i = 0; i < rchTxt.Text.Length; i++)
            {
                if (Char.IsWhiteSpace(Convert.ToChar(rchTxt.Text[i])))
                {
                    qtd++;
                }
            }

            MessageBox.Show("A quantidade de espaços em branco é: " + qtd.ToString());
        }

        private void btnQtdR_Click(object sender, EventArgs e)
        {
            int i = 0;

            foreach (char chara in rchTxt.Text)
            {
                if (chara == 'R' || chara == 'r')
                {
                    i++;
                }
            }

            MessageBox.Show("O texto tem " + i.ToString() + " letras R");
        }

        private void btnQtdPares_Click(object sender, EventArgs e)
        {
            int qtd = 0;

            for (int i = 0; i < rchTxt.Text.Length; i++)
            {
                if (Char.IsLetter(Convert.ToChar(rchTxt.Text[i])))
                {
                    if (i < rchTxt.Text.Length - 1 && rchTxt.Text[i] == rchTxt.Text[i + 1])
                    {
                        qtd++;
                    }
                }
            }

            MessageBox.Show("Quantidade de pares de letras: " + qtd.ToString());
        }
    }
}