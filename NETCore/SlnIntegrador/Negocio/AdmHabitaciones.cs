using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    /// <summary>
    /// Antes era una clase Concreta. Ahora es estatica.
    /// </summary>
    public static class AdmHabitaciones
    {
        static List<Habitacion> habitaciones;
        /// <summary>
        /// Creo lista de habitaciones e inserto con habitaciones.Add(), los datos de cada habitacion.
        /// </summary>
        /// <returns>La lista de "habitaciones"</returns>
        public static List<Habitacion> Listar()
        {
            //TODO
            habitaciones = new List<Habitacion>();

            habitaciones.Add(new Habitacion(2, "256", "Ocupado"));
            habitaciones.Add(new Habitacion(3, "635", "Ocupado"));
            habitaciones.Add(new Habitacion(5, "356", "Desocupado"));
            habitaciones.Add(new Habitacion(4, "89", "Ocupado"));
            habitaciones.Add(new Habitacion(1, "120", "Desocupado"));

            return habitaciones;
        }

        public static List<Habitacion> Listar(string estado)
        {
            //TODO
            habitaciones = new List<Habitacion>();
            return null;
        }

        public static int Insertar(Habitacion habitaciones)
        {
            //TODO
            return 0;
        }

        public static int Eliminar(int id)
        {
            //TODO
            return 0;
        }
        public static List<Habitacion> TraerUno(string numero)
        {
            //TODO
            return null;
        }
}
