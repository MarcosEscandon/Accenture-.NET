using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades3
{
    internal class Factura:DocumentoComercial
    {
        public Factura(string numero, DateTime fecha, string cliente, string direccion, string condicionIVA, string condicionVenta, string detalle, decimal total, string tipo) : base(numero, fecha, cliente, direccion, condicionIVA, condicionVenta, detalle, total)
        {
            Tipo = tipo;
        }
        public string Tipo { get; set; }
    }
}
