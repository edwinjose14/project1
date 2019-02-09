using CapaAccesoDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class ServicioProducto
    {
        RepositorioProducto repositorioProducto = new RepositorioProducto();

        public Producto CrearProducto(Producto producto) {
           producto =  new Producto(producto.Nit, producto.Nombre, producto.Marca, producto.Cantidad, producto.ValorUnitario);
            return producto;
        }
        public string Guardar(Producto producto) {

            if (repositorioProducto.Buscar(producto.Nit) == null)
            {
                repositorioProducto.Guardar(producto);
                return "El producto se guardo correctamente";
            }
            return "Error, no se puede guardar el producto";
        }

        public string Eliminar(Producto producto)
        {
            if (repositorioProducto.Buscar(producto.Nit) == null)
            {
                return "Error Al Eliminar  el Producto" +
                    " tal Vez No exista";
            }

            repositorioProducto.Eliminar(producto);
            return "Eliminado exitoso";
        }

        public List<Producto> Consultar()
        {
            return repositorioProducto.Consultar();

        }

        public Producto Buscar(string nit)
        {

            return repositorioProducto.Buscar(nit);
        }

        public string Modificar(Producto productoViejo, Producto productoNuevo)
        {


            repositorioProducto.Modificar(productoViejo, productoNuevo);

            return "Modificacion Exitosa";
        }
    }
}
