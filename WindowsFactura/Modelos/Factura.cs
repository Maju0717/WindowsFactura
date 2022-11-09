using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFactura.Modelos
{
    public class Factura
    {
        public Factura() { }
        public Factura(int nroFactura, Cliente cliente, Empleado empleado)
        {
            NroFactura = nroFactura;
            Cliente = cliente;
            Empleado = empleado;
        }

        public int NroFactura { get; set; }
        public Cliente Cliente { get; set; }
        public Empleado Empleado { get; set; }
        public List<DetalleFactura> DetalleFactura{get;set;}
    
}
