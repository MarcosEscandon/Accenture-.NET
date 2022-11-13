using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEmpleado
{
    public class Empleado:Persona
    {
        public Empleado(string nombre, string apellido, int id, int legago):base(nombre, apellido)
        {
           Id = id;
           Legajo = legago;
        }
        public int Id { get; set; }
        public int Legajo { get; set; }
        public Departamento Departamento { get; set; }
    }
}
