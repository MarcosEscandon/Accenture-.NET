using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Enfermero:Persona
    {
        public Enfermero(int id, string nombre, string apellido, string domicilio, string telefono, string email, string cuil) : base(id, nombre, apellido, domicilio, telefono, email)
        {
            Cuil = cuil;
        }

        public string Cuil { get; set; }
    }
}
