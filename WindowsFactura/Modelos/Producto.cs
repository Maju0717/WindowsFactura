using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFactura.Modelos
{
    public class Producto
    {
        public Producto() { }
        public Producto(string nombre,decimal precio,Categoria categoria) 
        {
            Nombre = nombre;
            Precio = precio;
            Categoria = categoria;
        }
        public string Nombre;
        public decimal Precio;
        public List<DetalleFactura> DetalleFactura { get; set; }
        public Categoria Categoria { get; set; }
    }
}
