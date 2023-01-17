using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp.Entidades
{
    public class Producto
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioCosto { get; set; }
        public double Margen { get; set; }
        public decimal IVA { get; set; }

        private decimal _PrecioBruto;
        private decimal _PrecioVenta;
        public decimal PrecioBruto
        {
            get
            {
               _PrecioBruto = PrecioCosto + Convert.ToDecimal(Margen);
                return _PrecioBruto;
            }
        }
        public decimal PrecioVenta
        {
            get
            {
                _PrecioVenta = PrecioBruto * Convert.ToDecimal(1 + IVA);
                return _PrecioVenta;    
                
            }
        }
        public string Categoria { get; set; }
    }
}
