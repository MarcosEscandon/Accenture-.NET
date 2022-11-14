using Models.ModelBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ModelDerivada
{
    public class Tripulacion
    {
        public Tripulacion(Piloto piloto, Copiloto copiloto, List<Azafata> azafatas)
        {
            Piloto = piloto;
            Copiloto = copiloto;
            Azafatas = azafatas;
        }
        public Azafata Azafata { get; set; }

        public Piloto Piloto { get; set; }
        public Copiloto Copiloto { get; set; }
        public List<Azafata> Azafatas { get; set; }
    }
}
