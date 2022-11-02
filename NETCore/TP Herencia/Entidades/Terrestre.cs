using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Terrestre: Motorizados
    {

        public Terrestre() { }

        public Terrestre(string marca, string color, string combustible, int cantidadCilindros, int ruedas, string utilidad):base(marca, color, combustible, cantidadCilindros)
        {
            Ruedas = ruedas;
            Utilidad = utilidad;
        }

        public int Ruedas { get; set; }
        public string Utilidad { get; set; }

    }
}
