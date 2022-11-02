using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Motorizados: Vehiculos
    {

        public Motorizados() { }

        public Motorizados(string marca, string color, string combustible, int cantidadCilindros):base(marca, color)
        {
            Combustible = combustible;
            CantidadCilindros = cantidadCilindros;
        }

        public string Combustible { get; set; }
        public int CantidadCilindros { get; set; }

    }
}
