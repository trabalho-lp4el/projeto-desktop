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
        public virtual List<Solicitacao> Solicitacoes { get; set; }
        public Boolean IsAusencia { get; set; }
        public long UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }

        public Boolean possuiSolicitacaoAtiva()
        {
            foreach (Solicitacao s in Solicitacoes)
            {
                if(!s.IsAplicado)
                {
                    return true;
                }
            }
            return false;
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
