using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vehiculos
    {
        public Vehiculos() {}

        public Vehiculos(string marca, string color)
        {
            Marca = marca;
            Color = color;
        }

        public string Marca { get; set; }
        public string Color { get; set; }
    }
}
