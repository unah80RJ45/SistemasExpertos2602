using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace invExperto
{
    public class Regla
    {
        public Func<Articulo, bool> Condicion { get; set; }
        public Func<Articulo, string> Conclusion { get; set; }
        //public Regla (Func<Articulo, bool> condicion, Func<Articulo, string> conclusion)
        //{
        //    Condicion  = condicion;
        //    Conclusion = conclusion;
        //}
        //public Regla()
        //{

        //}
    }
}
