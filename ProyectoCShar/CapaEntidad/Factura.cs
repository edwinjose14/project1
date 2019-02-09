using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Factura
    {

        public string NumeroFactura { get; set; }
        public DateTime FechaFactura { get; set; }
        public string IdentificacionCliente { get; set; }
        public double SubTotal { get; set; }
        public double Iva { get; set; }
        public double ValorTotal { get; set; }

        public void AgregarProducto() { }
        public void EliminarProducto() { }
        public void ConsultarProducto() { }

    }
}
