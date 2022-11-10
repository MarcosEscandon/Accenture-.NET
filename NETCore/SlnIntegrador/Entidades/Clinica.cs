using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Clinica
    {
        public Clinica(int id, string nombre, string domicilio, string telefono, string email)
        {
            Id = id;
            Nombre = nombre;
            Domicilio = domicilio;
            Telefono = telefono;
            Email = email;
        }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Domicilio { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
    }
}
