using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public static class DacMedico
    {
        static List<Medico> medicos;

        public static List<Medico> Select()
        {
            //TODO
            medicos = new List<Medico>();
            return null;
        }
        public static List<Medico> Select(string especialidad)
        {
            //TODO
            medicos = new List<Medico>();
            return null;
        }
        public static int Insert(Medico medicos)
        {
            //TODO
            return 0;
        }
        public static int Eliminar(int id)
        {
            //TODO
            return 0;
        }

        public static List<Medico> SelectById(int id)
        {
            //TODO
            return null;
        }
}
