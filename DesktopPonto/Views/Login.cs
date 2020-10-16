using DesktopPonto.Models;
using DesktopPonto.Service;
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

        private async void btnEntrar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Matricula = txbLogin.Text;
            usuario.Senha = txbSenha.Text;

            try
            {
                var response = await UsuarioService.postLogin(usuario);
                if (response == null)
                {
                    MessageBox.Show("Houve um problema no login ou senha");
                    return;
                }
                TelaPrincipal tela = new TelaPrincipal(response);
                tela.Show();
                this.Hide();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
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
