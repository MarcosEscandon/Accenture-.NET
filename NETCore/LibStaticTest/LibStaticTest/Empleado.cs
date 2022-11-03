using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibStaticTest
{
    public class Empleado
    {
        public Empleado(int id, string nombre, string apellido)
        {
            Id= id;
            Nombre= nombre;
            Apellido= apellido;
            //Comision=250
        }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        //static public decimal Comision { get; set; }

        private static int comision = 10;

        public static int Comision
        {
            get { return comision; }
            set { comision = value; }
        }
    }

}
