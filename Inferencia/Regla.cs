using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inferencia
{
    internal class Regla
    {
        public string Condicion { get; set; }
        public string Conlusion { get; set; }

        public Regla(string condicion, string conlusion)
        {
            Condicion = condicion;
            Conlusion = conlusion;
        }

    }
}
