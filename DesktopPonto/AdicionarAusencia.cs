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
    public partial class AdicionarAusencia : Form
    {
        private long idUsuario;
        public AdicionarAusencia()
        {
            InitializeComponent();
        }

        public AdicionarAusencia(long idUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var data = $"${txtDataAusencia.Text} ${txtHoraAusencia.Text}";
            var isValid = TimeSpan.TryParse(data, out var dummy);

            if(!isValid)
            {
                MessageBox.Show("Data informada inválida");
            }

            var pontoAusencia = new Ponto();
            pontoAusencia.IsAusencia = true;
            pontoAusencia.Horario = DateTime.ParseExact(data, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            try
            {
                var response = await AusenciaService.postAusencia(pontoAusencia);
                if(response == null)
                {
                    MessageBox.Show("Houve um problema na solicitação");
                    return;
                }
                this.Close();
            } catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdicionarAusencia_Load(object sender, EventArgs e)
        {

        }
    }
}
