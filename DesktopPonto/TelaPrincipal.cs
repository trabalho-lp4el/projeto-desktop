using DesktopPonto.Models;
using DesktopPonto.Service;
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
        private long idUsuario = 1;
        public TelaPrincipal()
        {
            
            InitializeComponent();

        }

        private async void TelaPrincipal_Load(object sender, EventArgs e)
        {
            flPontos.SuspendLayout();
            this.usuario = await getUsuario();
            setaValores();
            flPontos.ResumeLayout(false);

        }

        private void setaValores()
        {
            if(usuario == null)
            {
                return;
            }
            lblNomeUsuario.Text = $"Usuario: {usuario.Nome}";
            criaCamposPonto();
            preencheDiaAtual();
        }

        private void preencheDiaAtual()
        {
            lblCurrentDate.Text = $"Data: {getCurrentTime().Date.ToString("dd/MM/yyyy")}";
        }
        private void criaCamposPonto()
        {
            if(usuario.Pontos == null)
            {
                return;
            }
            usuario.Pontos.ForEach(ponto =>
            {
                GroupBox gpBox = new GroupBox();
                gpBox.Size = new Size(200, 73);

                Label labelData = geraLabel(ponto.getDataPonto(), 6, 16);
                labelData.Font = new Font("Arial", 12, FontStyle.Regular);
                labelData.Size = new Size(88, 20);

                Label labelHorario = geraLabel(ponto.IsAusencia ? "Ausencia": ponto.getHorarioPonto(), 101, 23);
                labelHorario.Font = new Font("Arial", 20, FontStyle.Regular);
                labelHorario.Size = new Size(82,31);

                Button botaoSolicitar = geraBotaoSolicitacao(ponto);
                botaoSolicitar.Size = new Size(93, 23);

                var innerPonto = ponto;
                botaoSolicitar.Click += (sender, e) =>
                {
                    abrirTelaSolicitacao(sender, e, innerPonto);
                };

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

        private Button geraBotaoSolicitacao(Ponto ponto)
        {
            Button button = new Button();
            button.Text = ponto.possuiSolicitacaoAtiva() ? "Possui solic." : "Solicitar Ajuste";
            button.Enabled = !ponto.possuiSolicitacaoAtiva();
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

        private void abrirTelaSolicitacao(object sender, EventArgs e,  Ponto ponto)
        {
            SolicitaMudanca formMudanca = new SolicitaMudanca(ponto);
            formMudanca.FormClosed += async (object senderForm, FormClosedEventArgs eForm) =>
            {
                this.Show();
                this.usuario = await getUsuario();
            };
            //formMudanca.Show();
            this.Hide();
            formMudanca.ShowDialog();
        }

        private void btnAddAusencia_Click(object sender, EventArgs e)
        {
            AdicionarAusencia formAusencia = new AdicionarAusencia(usuario.Id);
            formAusencia.FormClosed += async (object s, FormClosedEventArgs eForm) =>
            {
                this.Show();
                this.usuario = await getUsuario();
            };

            this.Hide();
            formAusencia.ShowDialog();

        }

        private async Task<Usuario> getUsuario()
        {
            try
            {
                var usuario = await UsuarioService.getUsuario(idUsuario);
                return usuario;
            } catch(Exception e)
            {
                return null;
            }
            
        }
    }
}
