using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Usuarios WHERE nome=@nome AND senha=@senha";

            Conexao conexao = new Conexao();
            conexao.conectar();

            OleDbCommand cmd = new OleDbCommand(query, conexao.cn);

            cmd.Parameters.AddWithValue("@nome", txtUsuario.Text);
            cmd.Parameters.AddWithValue("@senha", txtSenha.Text);

            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read()) {
                Autenticacao.login(dr["nome"].ToString(), dr["senha"].ToString(), Convert.ToInt32(dr["nivel"]));
                btnInformacoes.Enabled = true;
            }
            else
            {
                MessageBox.Show("Erro: Usuário e/ou senha não encontrados");
            }
        }

        private void btnInformacoes_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Autenticacao.getUsario());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Autenticacao.logout();
            btnInformacoes.Enabled = false;
        }
    }
}
