using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Habitacion
    {
        public Habitacion(int id, string numero, string estado)
        {
            Id = id;
            Numero = numero;
            Estado = estado;

        }

        public int Id { get; set; }
        public string Numero { get; set; }
        public string Estado { get; set; }
    }
}
