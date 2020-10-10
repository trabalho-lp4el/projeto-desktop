using DesktopPonto.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopPonto
{
    public partial class TelaPrincipal : Form
    {
        private Usuario usuario = new Usuario();
        public TelaPrincipal()
        {
            
            InitializeComponent();
        }

        public void criaUsuario()
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
                    ponto.Horario = new DateTime(2020, 5, i + 1, x + 8, 30, 0);
                    pontos.Add(ponto);

                }
                

            }
            usuario.Pontos = pontos;
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {
            flPontos.SuspendLayout();
            criaUsuario();
            setaValores();
            flPontos.ResumeLayout(false);

        }

        private void setaValores()
        {
            lblNomeUsuario.Text = $"Usuario: {usuario.Nome}";
            criaCamposPonto();
            preencheDiaAtual();
            iniciaThreadHorario();
        }

        private void preencheDiaAtual()
        {
            lblCurrentDate.Text = $"Data: {getCurrentTime().ToString("dd/mm/yyyy")}";
        }

        private void iniciaThreadHorario()
        {
            //lblCurrentHour.Invoke((MethodInvoker)(() =>
            //{
            //    string currentTime = getCurrentTime().ToString("HH:mm");
            //    if (lblCurrentHour.Text != currentTime)
            //   {
            //        lblCurrentHour.Text = currentTime;
            //    }
            //}));
        }



        private void criaCamposPonto()
        {
            usuario.Pontos.ForEach(ponto =>
            {
                GroupBox gpBox = new GroupBox();
                gpBox.Size = new Size(200, 73);

                Label labelData = geraLabel(ponto.getDataPonto(), 6, 16);
                labelData.Font = new Font("Arial", 12, FontStyle.Regular);
                labelData.Size = new Size(88, 20);

                Label labelHorario = geraLabel(ponto.getHorarioPonto(), 101, 23);
                labelHorario.Font = new Font("Arial", 20, FontStyle.Regular);
                labelHorario.Size = new Size(82,31);

                Button botaoSolicitar = geraBotaoSolicitacao();
                botaoSolicitar.Size = new Size(93, 23);

                gpBox.Controls.Add(labelData);
                gpBox.Controls.Add(labelHorario);
                gpBox.Controls.Add(botaoSolicitar);

                gpBox.TabIndex = (int) ponto.Id;

                flPontos.Controls.Add(gpBox);
            });
            
        }

        private Label geraLabel(string texto, int x, int y)
        {
            Label label = new Label();
            label.Text = texto;
            label.Location = new Point(x, y);
            return label;

        }

        private Button geraBotaoSolicitacao()
        {
            Button button = new Button();
            button.Text = "Solicitar Ajuste";
            button.Location = new Point(2, 39);
            return button;
        }

        public DateTime getCurrentTime()
        {
            return DateTime.Now;
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            string current = getCurrentTime().ToString("HH:mm");
            lblCurrentHour.Text = current;
        }
    }
}
