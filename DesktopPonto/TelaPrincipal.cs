using DesktopPonto.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopPonto
{
    public partial class TelaPrincipal : Form
    {
        private Usuario usuario = new Usuario();
        public TelaPrincipal()
        {
            usuario.Nome = "Danilo";
            usuario.Matricula = "69420";
            List<Ponto> pontos = new List<Ponto>();
            for(int i = 0; i < 5; i++)
            {
                for(int x = 0; x < 4; x++)
                {
                    Ponto ponto = new Ponto();
                    ponto.Id = i + x + 1;
                    ponto.Horario = new DateTime(2020, 5, i+1, (x + 8), 30, 0);
                    pontos.Add(ponto);
                }
            }


            usuario.Pontos = pontos;
            
            InitializeComponent();
            setaValores();
        }

        private void setaValores()
        {
            lblNomeUsuario.Text = $"Usuario: {usuario.Nome}";
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
