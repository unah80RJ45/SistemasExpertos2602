using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace invExperto
{
    public class Articulo
    {
        public string Codigo { get; set; }
        public int Existencia { get; set; }
        public int Promedio { get; set; }
        public int Minimo { get; set; }
        public int Tiempo { get; set; }
        public Articulo(DataRow row)
        {
            Codigo = row[0].ToString(); Existencia = (int) row[1]; Promedio = (int) row[2];
            Minimo = (int) row[3]; Tiempo = (int) row[4];    
        }
    }
}
