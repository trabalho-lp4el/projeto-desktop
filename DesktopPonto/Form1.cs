using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DesktopPonto
{
    public partial class F_Principal : Form
    {
        public F_Principal()
        {
            InitializeComponent();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            // String txt;
            // txt = tb_nome.Text;
            // lb_textoteste.Text = txt;
            //lb_textoteste.Text = tb_nome.Text;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(tb_nome.Text == "")
            {
                MessageBox.Show("Digite um valor");
                tb_nome.Focus();
                return;
            }
            tb_LISTA.Text += tb_nome.Text +", ";

            tb_nome.Clear();
            tb_nome.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
