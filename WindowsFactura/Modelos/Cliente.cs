using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFactura.Modelos
{
    public class Cliente
    {
        public Cliente() { }
        public Cliente(string apellido, string nombre, int dNI,Usuario usuario)
        {
            Apellido = apellido;
            Nombre = nombre;
            DNI = dNI;
            Usuario = usuario;
        }

        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public int DNI { get; set; }
        public Usuario Usuario { get; set; }
        public List<Factura> Factura { get; set; }
    }
    }
}
