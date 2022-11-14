using Entidades.EntidadesBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.EntidadesDerivadas.Pediatria
{
    public class MedicoPediatra : Medico
    { 
        public MedicoPediatra(int nroConsultorio, string matricula, string nombre, string apellido, string dni, DateTime fechaNacimiento): base (matricula, nombre, apellido, dni, fechaNacimiento)
        {
            NroConsultorio = nroConsultorio;
        }

        public MedicoPediatra() { }

        public int NroConsultorio { get; set; }
    }
}
