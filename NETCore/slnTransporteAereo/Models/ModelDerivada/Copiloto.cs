using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ModelDerivada
{
    public class Copiloto
    {
        public Copiloto(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
            
        }

        public Copiloto() { }

        public string Nombre { get; set; }
        public string Apellido { get; set; }
   
    }
}
