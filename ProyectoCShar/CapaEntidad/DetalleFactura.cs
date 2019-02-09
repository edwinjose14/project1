using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class DetalleFactura
    {
        public string IdentificacionProducto { get; set; }
        public string NombreServicio { get; set; }
        public string NombreProducto { get; set; }
        public int Cantidad { get; set; }
        public double ValorUnitario { get; set; }
        public double ValorTotal { get; set; }
    }
}
