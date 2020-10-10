using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopPonto.Models
{
    class Solicitacao
    {
        public long Id { get; set; }
        public bool IsAplicado { get; set; }
        public DateTime NovoHorario { get; set; }

    }
}
