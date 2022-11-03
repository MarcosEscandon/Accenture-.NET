using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibAnimales
{
    internal class Leon : Animal
    {
        public Leon(string edad, string longitud, string peso, string nombre, string sonido) : base(edad, longitud, peso)
        {
            Nombre = nombre;
            Sonido = sonido;
        }
        public string Nombre { get; set; }
        public string Sonido { get; set; }

        public override string Imprimir()
        {
            return $"Nombre: {Nombre}, Sonido: {Sonido} {base.Imprimir()}";
        }
        public override string ImprimirComida(string comida)
        {
            return "Comida: " + comida;
        }
    }
}
