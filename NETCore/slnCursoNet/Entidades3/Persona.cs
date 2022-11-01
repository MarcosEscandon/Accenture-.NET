using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades3
{
    public abstract class Persona
    {
        public Persona() { }
        public Persona(string nombre, string apellido, string email, string telefono, string direccion)
        {

            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            Telefono = telefono;
            Direccion = direccion;
        }
        public string Nombre { set; get; }
        public string Apellido { set; get; }
        public string Email { set; get; }
        public string Telefono { set; get; }
        public string Direccion { set; get; }
    }
}
