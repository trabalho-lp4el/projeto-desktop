using DesktopPonto.Models;
using DesktopPonto.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace DesktopPonto
{
    public partial class SolicitaMudanca : Form
    {
        private Ponto ponto;
        private Solicitacao solicitacao = new Solicitacao();
        public SolicitaMudanca()
        {
            InitializeComponent();
        }

        public SolicitaMudanca(Ponto ponto)
        {
            preenchePonto(ponto);
            InitializeComponent() ;
        }

        private async void preenchePonto(Ponto ponto)
        {
            this.ponto = await SolicitacaoService.getPonto(ponto.Id);
        }
        private void SolicitaMudanca_Load(object sender, EventArgs e)
        {
            carregaInfos();
        }

        private void carregaInfos()
        {
            if(ponto == null)
            {
                return;
            }
            lblDataPonto.Text = ponto.getDataPonto();
            mtHorario.Text = ponto.getHorarioPonto();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mtHorario_TextChanged(object sender, EventArgs e)
        {
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var isValid = TimeSpan.TryParse(mtHorario.Text, out var dummyOutput);
            if(!isValid)
            {
                MessageBox.Show("Horário informado inválido");
                return;
            }
            var novoHorario = $"{ponto.getDataPonto()} {mtHorario.Text}";
            //DateTime.TryParseExact(novoHorario, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None ,out var dummy);
            solicitacao.NovoHorario = DateTime.Parse(novoHorario);
            solicitacao.PontoId = ponto.Id;
           var response = await SolicitacaoService.postSolicitacao(solicitacao);

            if(response == null)
            {
                MessageBox.Show("Houve um problema na solicitação");
                return;
            }

            this.Close();
        }
    }
}
