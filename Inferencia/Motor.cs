using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inferencia
{
    internal class Motor
    {
        private List<Regla> reglas = new List<Regla>();
        private HashSet<string> hechos = new HashSet<string>();

        public void nuevaRegla(string condicion, string conclusion)
        {
            Regla regla = new Regla(condicion, conclusion);
            reglas.Add(regla);
        }
        public void nuevoHecho(string hecho)
        {
            hechos.Add(hecho);
        }
        public void Ejecutar(RichTextBox texto)
        {
            bool esNuevoHecho;

            do
            {
                esNuevoHecho = false;
                foreach (var regla in reglas)
                {
                    if(hechos.Contains(regla.Condicion) && !hechos.Contains(regla.Conlusion))
                    {
                        texto.AppendText($"Aplicando Regla: Si { regla.Condicion} entonces {regla.Conlusion}\n");
                        //texto.AppendText("Aplicando Relga Si" + regla.Condicion + " entonces " + regla.Conlusion + "\n");

                        hechos.Add(regla.Conlusion);
                        esNuevoHecho = true;
                    }
                }
            } while (esNuevoHecho);
        }
        public void Mostrar(RichTextBox texto)
        {
            texto.AppendText("\nHechos Conocidos\n");
            foreach (var hecho in hechos)
            {
                texto.AppendText($"- {hecho}\n");
            }
        }
        public void Limpiar()
        {
            hechos = new HashSet<string>();
        }
    }
}
