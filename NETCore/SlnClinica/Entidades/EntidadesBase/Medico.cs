using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.EntidadesBase
{
    public abstract class Medico : Persona
    {
        #region Constructores
        public Medico( string matricula, string nombre, string apellido, string dni, DateTime fechaNacimiento):base(nombre, apellido,dni,fechaNacimiento)
        {
            Matricula = matricula;
        }
        public Medico() { }
        #endregion
        public string Matricula { get; set; }
    }
}
