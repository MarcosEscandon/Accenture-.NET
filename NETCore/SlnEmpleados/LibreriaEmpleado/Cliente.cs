using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEmpleado
{
    public class Cliente:Persona
    {
        public int Cuit { get; set; }
        public int Telefono { get; set; }
    }
}
