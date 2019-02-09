using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Ventas
    {
        public string NumeroVenta { get; set; }
        public DateTime FechaVenta { get; set; }
        public string NumeroFactura { get; set; }

        public void AgregarVenta() { }
        public void ConsultarVenta() { }
    }
}
