using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Aereo: Motorizados
    {
        public Aereo() { }

        public Aereo(string marca, string color, string combustible, int cantidadCilindros, int motores, int alturaMaxima) : base(marca, color, combustible, cantidadCilindros)
        {
            Motores = motores;
            AlturaMaxima = alturaMaxima;
        }

        public int Motores { get; set; }
        public int AlturaMaxima { get; set; }

    }
}
