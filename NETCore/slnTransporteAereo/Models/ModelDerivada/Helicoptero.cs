using Models.ModelBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ModelDerivada
{
    public class Helicoptero : Transporte
    {
        public Helicoptero(int cantidadAspas, int capacidad, decimal velocidad, decimal costoPorHora) : base(capacidad, velocidad, costoPorHora)
        {
            CantidadAspas = cantidadAspas;
        }
        public Helicoptero() { }

        public int CantidadAspas { get; set; }



        public override string Aterrizar(bool Pista)
        {
            return "Aterrizando";
        }

        public override string Despegar(bool Pista)
        {
            string VelocidadCrucero = "Despegando";

            if (Velocidad >= 160)
            {
                VelocidadCrucero = "Despegando, Velocidad crucero alcanzada";
            }

            return VelocidadCrucero;
        }
        public override string Mostrar()
        {
            return $"Velocidad: {Velocidad} \nCosto Por Hora: {CostoPorHora} \nCapacidad: {Capacidad} \nCantidad de Aspas: {CantidadAspas} ";
        }
    }
}
