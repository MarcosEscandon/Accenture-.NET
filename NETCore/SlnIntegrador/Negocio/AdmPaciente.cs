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
    public static class AdmPaciente
    {
        static List<Paciente> pacientes;
        /// <summary>
        /// Creo lista de pacientes e inserto con pacientes.Add(), los datos de cada paciente.
        /// </summary>
        /// <returns> La lista de "pacientes"</returns>
        /// 
        public static List<Paciente> Insertar()
        {
            //Creo la lista
            pacientes = new List<Paciente>();

            //Metodo add a la lista pacientes y genero objeto anonimo
            pacientes.Add(new Paciente(5, "Malena", "Gomez", "Algun lado 215", "42598211", "malena@gmail.com", "ASC256", new DateTime(2019, 10, 11)));
            pacientes.Add(new Paciente(2, "Juan Carlos", "Perez", "No se 525", "12543658", "juanCarlos@gmail.com", "SDE123", new DateTime(2000, 10, 11)));
            pacientes.Add(new Paciente(4, "Maria", "Martinez", "San Martin 225", "12358741", "maria@gmail.com", "DFE578", new DateTime(2018, 10, 11)));
            pacientes.Add(new Paciente(1, "Cristian", "Rodriguez", "J.M. Rosas 569", "25698741", "cristian@gmail.com", "GGT587", new DateTime(1998, 10, 11)));
            pacientes.Add(new Paciente(8, "Ronald", "Wisley", "Callejón Mágico 24", "56987412", "Ronald@gmail.com", "FRE256", new DateTime(1989, 10, 11)));

            //TODO
            return pacientes;
        }

        public static int Insertar(Paciente pacientes)
        {
            //TODO
            return 0;
        }
        public static int Eliminar(int id)
        {
            //TODO
            return 0;
        }
        public static List<Paciente> TraerUno(string nroHistoriaClinica)
        {

            //TODO
            return null;
        }
    }
}
