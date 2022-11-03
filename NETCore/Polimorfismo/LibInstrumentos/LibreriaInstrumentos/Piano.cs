using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LibreriaInstrumentos.InstrumentoGeneral;

namespace LibreriaInstrumentos
{
    public class Piano:InstrumentoMusical
    {
       public override string Afinar(string nombre)
        {
            return "Afinando "+nombre;
        }
    }
}
