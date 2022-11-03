using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibAnimales
{
    internal class Loro : Animal
    {
        public Loro(string edad, string longitud, string peso, string nombre, string hablar) : base(edad, longitud, peso)
        {
            Nombre = nombre;
            Hablar = hablar;
        }
        public string Nombre { get; set; }
        public string Hablar { get; set; }

        public override string Imprimir()
        {
            return $"Nombre:{Nombre}, Hablar:{Hablar} {base.Imprimir()}";
        }
        public override string ImprimirComida(string comida)
        {
            return "Comida: " + comida;
        }
    }
}
