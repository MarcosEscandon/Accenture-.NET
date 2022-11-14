using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ModelDerivada
{
    public class Azafata
    {
        public Azafata(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
            
        }
        public Azafata() { }

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        
    }
}

