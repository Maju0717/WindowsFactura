using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFactura.Modelos
{
    public class Usuario
    {
        public Usuario() { }
        public Usuario(string nombre, int nroUsuario,Cliente cliente)
        {
            Nombre = nombre;
            NroUsuario = nroUsuario;
            Cliente = cliente;
        }

        public string Nombre { get; set; }
        public int NroUsuario { get; set; }
        public Cliente Cliente { get; set; }
    }
}
