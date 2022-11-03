using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibAjedrez
{
    internal class Alfil:Pieza
    {
        public override string Mover(string movimiento)
        {
            return "El Alfil se mueve hacia "+movimiento;
        }
    }
}
