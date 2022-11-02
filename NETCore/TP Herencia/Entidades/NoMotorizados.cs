using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class NoMotorizados: Vehiculos
    {

        public NoMotorizados() { }

        public NoMotorizados(string marca, string color, int ruedas, string traccion):base(marca, color)
        {
            Ruedas = ruedas;
            Traccion = traccion;
        }

        public int Ruedas { get; set; } // cantidad de ruedas
        public string Traccion { get; set; } // pedal, patada (bici, skate)
    }
}
