using Models.ModelBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ModelDerivada
{
    public class Jet : Transporte
    {
        public Jet(Tripulacion tripulacion, int capacidad, decimal costoPorHora, decimal velocidad) : base(capacidad, velocidad, costoPorHora)
        {
            Tripulacion = tripulacion;
        }

        public Jet() { }

        public Jet(Piloto piloto, Copiloto copiloto, int capacidad, decimal costoPorHora, decimal velocidad) : base(capacidad, velocidad, costoPorHora)
        {
            Tripulacion.Piloto = piloto;
            Tripulacion.Copiloto = copiloto;
            Tripulacion.Azafata = null;
        }

        public Tripulacion Tripulacion { get; set; }


        public override string Aterrizar(bool Pista)
        {
            return "Aterrizando";
        }

        public override string Despegar(bool Pista)
        {
            return "Despegando";
        }

        public string Informar()
        {
            return $"Nombre del piloto: {Tripulacion.Piloto.Nombre} Apellido del Piloto: {Tripulacion.Piloto.Apellido} \n" +
                $"Nombre del copiloto: {Tripulacion.Copiloto.Nombre} Apellido del colipoto: {Tripulacion.Copiloto.Apellido} \n" +
                $"Nombre de la azafata: {Tripulacion.Azafatas[0].Nombre} Apellido de la azafata: {Tripulacion.Azafatas[0].Apellido}\n" +
                $"Cantidad de pasajeros del Jet: {Capacidad}";
        }

        public string AgregarAzafata(Azafata azafata)
        {
            Tripulacion.Azafatas.Add(azafata);

            return "Nombre: " + azafata.Nombre + "Apellido: " + azafata.Apellido;
        }
    }
     
}
