using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibAnimales
{
    public abstract class Animal
    {
        private string EdadAnimal;
        private string LongitudAnimal;
        private string PesoAnimal;
        public Animal(string edad, string longitud, string peso)
        {
            EdadAnimal = edad;
            LongitudAnimal = longitud;
            PesoAnimal = peso;
        }

        public string Edad { get { return EdadAnimal; } }
        public string Longitud { get { return LongitudAnimal; } }
        public string Peso { get { return PesoAnimal; } }

        public virtual string Imprimir()
        {
            return $"Edad: {Edad}, Altura: {Longitud}, Peso:{Peso},";
        }
        public abstract string ImprimirComida(string comida);
    }
    
}
