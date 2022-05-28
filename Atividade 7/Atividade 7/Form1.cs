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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frm1"];

            if (fc != null)
            {
                fc.Close();
            }

            frm1 frm = new frm1();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frm2"];

            if (fc != null)
            {
                fc.Close();
            }

            frm2 frm = new frm2();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frm3"];

            if (fc != null)
            {
                fc.Close();
            }

            frm3 frm = new frm3();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frm4"];

            if (fc != null)
            {
                fc.Close();
            }

            frm4 frm = new frm4();
            frm.Show();
        }
    }
}