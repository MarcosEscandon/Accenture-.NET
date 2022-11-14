using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ModelDerivada
{
    public class Piloto
    {
        public Piloto(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
         
        }

        public Piloto() { }

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        
    }
}
