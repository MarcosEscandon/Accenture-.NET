using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades3
{
    internal class Vendedor:Persona
    {
        public Vendedor(string nombre, string apellido, string email, string telefono, string direccion, string dni) : base(nombre, apellido, email, telefono, direccion)
        {
            DNI = dni;
        }
        public string DNI { set; get; }
    }
}
