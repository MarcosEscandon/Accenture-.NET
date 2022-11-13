using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEmpleado
{
    public class Cliente:Persona
    {
        public Cliente(string nombre, string apellido, int cuit, int telefono):base(nombre, apellido)
        {
            Cuit = cuit;
            Telefono = telefono;
        }

        public int Cuit { get; set; }
        public int Telefono { get; set; }
    }
}
