using DesktopPonto.Models;
using DesktopPonto.Views;
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

        private void cmdAddLista_Click(object sender, EventArgs e)
        {
            if (cmdAddLista.Text.Length > 0)
                ListNames.Items.Add(tb_nome.Text);
            else
                MessageBox.Show("Digite um valor");
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            if(ListNames.SelectedIndex.Equals(true))
                ListNames.Items.RemoveAt(ListNames.SelectedIndex);
            else
                MessageBox.Show("Selecione um item da lista");
        }







        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Controller controle = new Controller();
            controle.acessar(txbLogin.Text, txbSenha.Text);
            if (controle.mensagem.Equals(""))
            {
                if (controle.tem)
                {
                    MessageBox.Show("Logado com sucesso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BemVindo bv = new BemVindo();
                    bv.Show();
                }
                else
                {
                   // MessageBox.Show("Login não encontrado", "Verifique login e senha", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }else
            {
                MessageBox.Show(controle.mensagem);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastreSe cad = new CadastreSe();
            cad.Show();
        }
    }
}
