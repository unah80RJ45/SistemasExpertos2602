using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace invExperto
{
    public class Motor
    {
        private List<Articulo> Inventario;
        private List<Regla> reglas = new List<Regla>();

        public void nuevaRegla(Func<Articulo, bool> condicion, Func<Articulo, string> conclusion)
        {
            Regla regla = new Regla { Condicion = condicion, Conclusion = conclusion};
            //Regla rule = new Regla();
            //rule.Conclusion = conclusion;
            //rule.Condicion = condicion;
            //Regla r = new Regla(condicion, conclusion);

            reglas.Add(regla);
        }
        public Motor(List<Articulo> inventario)
        {
            Inventario = inventario;
        }
        public List<string> Evaluar()
        {
            var conclusiones = new List<string>();

            foreach (var item in Inventario)
            {
                foreach (var regla in reglas)
                {
                    if(regla.Condicion(item))
                    {
                        string conclusion = regla.Conclusion(item);
                        conclusiones.Add(conclusion);
                    }
                }
            }
            return conclusiones;
        }
    }
}
