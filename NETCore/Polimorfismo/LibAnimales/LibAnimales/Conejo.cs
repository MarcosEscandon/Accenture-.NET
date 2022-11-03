using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibAnimales
{
    internal class Conejo : Animal
    {
        public Conejo(string edad, string longitud, string peso, string salto, string nombre) : base(edad, longitud, peso)
        {
            Salto = salto;
            Nombre = nombre;
        }
        public string Salto { get; set; }
        public string Nombre { get; set; }
        public override string Imprimir()
        {
            return $"Nombre:{Nombre}, Salto:{Salto} {base.Imprimir()}";
        }

        public override string ImprimirComida(string comida)
        {
            return "Comida: " + comida;
        }
    }
}
