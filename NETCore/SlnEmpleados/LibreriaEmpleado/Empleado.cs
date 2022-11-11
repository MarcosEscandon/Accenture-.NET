using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEmpleado
{
    public class Empleado:Persona
    {
        public int Id { get; set; }
        public int Legajo { get; set; }
        public Departamento Departamento { get; set; }
    }
}
