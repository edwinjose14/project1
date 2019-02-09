using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Producto
    {
        public Producto(string nit, string nombre, string marca, int cantidad, double valorUnitario)
        {
            Nit = nit;
            Nombre = nombre;
            Marca = marca;
            Cantidad = cantidad;
            ValorUnitario = valorUnitario;
        }
        public Producto()
        {
                
        }

        public string Nit { get; set; }
        public string Nombre { get; set; }
        public string Marca { get; set; }

        public int Cantidad { get; set; }
        public double ValorUnitario { get; set; }

        public void AgregarProducto() { }
        public void EliminarProducto() { }
        public void ConsultarProducto() { }
    }
}
