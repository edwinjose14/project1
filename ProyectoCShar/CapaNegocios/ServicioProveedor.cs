using CapaAccesoDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class ServicioProveedor
    {
        RepositorioProveedor repositorioProveedor = new RepositorioProveedor();

        public string Guardar(Proveedor proveedor)
        {

            if (repositorioProveedor.Buscar(proveedor.Nit) == null)
            {
                repositorioProveedor.Guardar(proveedor);
                return "El Proveedor se guardo correctamente";
            }
            return "Error, no se puede guardar el Proveedor";
        }

        public string Eliminar(Proveedor proveedor)
        {
            if (repositorioProveedor.Buscar(proveedor.Nit) == null)
            {
                return "Error Al Eliminar  el Proveedor" +
                    " tal Vez No exista";
            }

            repositorioProveedor.Eliminar(proveedor);
            return "Eliminado exitoso";
        }

        public List<Proveedor> Consultar()
        {
            return repositorioProveedor.Consultar();

        }

        public Proveedor Buscar(string nit)
        {

            return repositorioProveedor.Buscar(nit);
        }

        public string Modificar(Proveedor proveedorViejo, Proveedor proveedorNuevo)
        {


            repositorioProveedor.Modificar(proveedorViejo, proveedorNuevo);

            return "Modificacion Exitosa";
        }

    }
}
