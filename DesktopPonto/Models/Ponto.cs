using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopPonto.Models
{
    public class Ponto
    {
        public long Id { get; set; }
        public DateTime Horario { get; set; }

        public Solicitacao solicitacao { get; set; }

        public Boolean isAusencia { get; set; }
        public long IdUsuario { get; set; }

        public Boolean possuiSolicitacaoAtiva()
        {
            return solicitacao != null && !solicitacao.IsAplicado;
        }

        public string getDataPonto()
        {
            return Horario.Date.ToString("dd/MM/yyyy");
        }

        public string getHorarioPonto()
        {
            return Horario.ToString("HH:mm");
        }
    }
}
