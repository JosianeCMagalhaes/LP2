﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PF_0030482013048
{
    public partial class frmPrincipal : Form
    {
        public static SqlConnection conexao;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cadastroDeCidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // verificar se o formulário já está na memória
            Form fc = Application.OpenForms["frmCidade"];
            if (fc != null)
                fc.Close();

            frmCidade frmC = new frmCidade();
            frmC.MdiParent = this;
            frmC.WindowState = FormWindowState.Maximized;
            frmC.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                // aqui a conexão vai depende da sua máquina da escola ou particular
              //  conexao = new SqlConnection("Data Source=PROFDENILCE\\SQLEXPRESS;Initial Catalog=LP2;Integrated Security=True");



                conexao = new SqlConnection("Data Source=DESKTOP-EN83RRN;Initial Catalog=LP_;Integrated Security=True;Pooling=False");
                conexao.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro de banco de dados =/" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Outros Erros =/" + ex.Message);
            }
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // seu formulario
            frmSobre frmS = new frmSobre();
            frmS.Show();

            //formulario do VS
           // AboutBox1 frmS = new AboutBox1();
           // frmS.Show();

        }
    }
}
