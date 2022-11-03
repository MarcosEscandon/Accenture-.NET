using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibAjedrez
{
    internal class Reina:Pieza
    {
        public override string Mover(string movimiento)
        {
            return "La Reina se mueve hacia " + movimiento;
        }
    }
}
