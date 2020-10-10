using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopPonto.Models
{
    class Usuario
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public List<Ponto> Pontos { get; set; }
        public string Matricula { get; set; }


    }
}
