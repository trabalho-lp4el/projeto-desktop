using DesktopPonto.Models;
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
        private Solicitacao solicitacao;
        public SolicitaMudanca()
        {
            InitializeComponent();
        }

        public SolicitaMudanca(Ponto ponto)
        {
            this.ponto = ponto;
            InitializeComponent();
        }
        private void SolicitaMudanca_Load(object sender, EventArgs e)
        {
            carregaInfos();
        }

        private void carregaInfos()
        {
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

        private void button1_Click(object sender, EventArgs e)
        {
            var isValid = TimeSpan.TryParse(mtHorario.Text, out var dummyOutput);
            if(!isValid)
            {
                MessageBox.Show("Horário informado inválido");
                return;
            }
            var novoHorario = $"{ponto.getDataPonto()} {mtHorario.Text}";
            solicitacao.NovoHorario = DateTime.ParseExact(novoHorario, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            solicitacao.IdPonto = ponto.Id;
            ponto.solicitacao = solicitacao;
        }
    }
}
