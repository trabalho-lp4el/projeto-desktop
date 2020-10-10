using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopPonto.Models
{
    class Ponto
    {
        public long Id { get; set; }
        public DateTime Horario { get; set; }

        public Solicitacao solicitacao { get; set; }

        public Boolean possuiSolicitacaoAtiva()
        {
            return solicitacao != null && !solicitacao.IsAplicado;
        }

        public string getDataPonto()
        {
            return Horario.Date.ToString();
        }

        public string getHorarioPonto()
        {
            return Horario.ToString("HH:mm");
        }
    }
}
