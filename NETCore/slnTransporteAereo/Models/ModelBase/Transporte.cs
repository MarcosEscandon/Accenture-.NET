using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ModelBase
{
    public abstract class Transporte
    {
        public Transporte(int capacidad, decimal velocidad, decimal costoPorHora)
        {
            Capacidad = capacidad;
            Velocidad = velocidad;
            CostoPorHora = costoPorHora;
        }

        public Transporte() { }

        public int Capacidad { get; set; }
        public decimal Velocidad { get; set; }
        public decimal CostoPorHora { get; set; }

        public virtual string Mostrar()
        {
            return $"Velocidad: {Velocidad} \nCosto Por Hora: {CostoPorHora} \nCapacidad: {Capacidad} ";
        }

        public abstract string Aterrizar(bool Pista);

        public abstract string Despegar(bool Pista);
    }
}
