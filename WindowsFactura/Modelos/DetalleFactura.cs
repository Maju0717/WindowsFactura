using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFactura.Modelos
{
    public class DetalleFactura
    {
        public DetalleFactura() { }
        public DetalleFactura(Factura factura,Producto producto)
        {
           Factura = factura;
           Producto = producto;
        } 
        public Factura Factura { get; set; }
        public Producto Producto { get; set; }


    }
}
