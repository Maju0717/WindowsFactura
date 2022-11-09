using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFactura.Modelos
{
    public class Empleado
    {
        public Empleado() { }
        public Empleado(string nombre, string apellido, int dni, int legajo,Factura factura)
        {
            Nombre = nombre;
            Apellido = apellido;
            DNI = dni;
            Legajo = legajo;
            Factura = factura;
        }

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public int Legajo { get; set; }
        public Factura Factura { get; set; }

    }
}
