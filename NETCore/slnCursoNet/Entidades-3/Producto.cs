using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades3
{
    internal class Producto
    {
        public string Nombre { set; get; }
        public string Descripcion { set; get; }
        public decimal PrecioCosto { set; get; }
        public double Margen { set; get; }
        public double IVA { set; get; }
        //public decimal PrecioBruto {  get; }
        // public decimal PrecioVenta {  get; }
        public string Proveedor { set; get; }
        public string Categoria { set; get; }
        public string SubCategoria { set; get; }

        public decimal PrecioBruto
        {
            get { return PrecioCosto + Convert.ToDecimal(this.Margen); }
        }
        public decimal PrecioVenta
        {
            get { return PrecioBruto * Convert.ToDecimal(1 + this.IVA); }
        }
    }
}

