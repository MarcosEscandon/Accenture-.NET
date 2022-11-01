using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioCosto { get; set; }
        public double Margen { get; set; }
        public double IVA { get; set; }
        public decimal PrecioBruto
            {
                get
                {
                    decimal _PrecioBruto = 0;
                    {
                        _PrecioBruto = this.PrecioCosto + Convert.ToDecimal(this.Margen);
                    }
                    return _PrecioBruto;
                }
            }
        public decimal PrecioVenta
        {
            get
            {
                decimal _PrecioVenta = 0;
                {
                    _PrecioVenta = this.PrecioBruto + Convert.ToDecimal(this.IVA);
                }
                return _PrecioVenta;
            }
        }
        public string Proveedor { get; set; }
        public string Categoria { get; set; }
        public string SubCategoria { get; set; }
    
    }
}