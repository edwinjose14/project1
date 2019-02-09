using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Proveedor
    {
        public string Nit { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Ciudad { get; set; }
        public string Direccion { get; set; }

        public void AgregarProducto() { }
        public void EliminarProducto() { }
        public void ConsultarProducto() { }
        public void AgregarProductosVendidos() { }
    }
}
