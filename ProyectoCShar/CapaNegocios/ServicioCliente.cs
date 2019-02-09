using CapaAccesoDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class ServicioCliente
    {
        RepositorioCliente repositorioCliente = new RepositorioCliente();

        public string Guardar(Cliente cliente)
        {

            if (repositorioCliente.Buscar(cliente.Identificacion) == null)
            {
                repositorioCliente.Guardar(cliente);
                return "El Cliente se guardo correctamente";
            }
            return "Error, no se puede guardar el producto";
        }

        public string Eliminar(Cliente cliente)
        {
            if (repositorioCliente.Buscar(cliente.Identificacion) == null)
            {
                return "Error Al Eliminar  el Cliente" +
                    " tal Vez No exista";
            }

            repositorioCliente.Eliminar(cliente);
            return "Eliminado exitoso";
        }

        public List<Cliente> Consultar()
        {
            return repositorioCliente.Consultar();

        }

        public Cliente Buscar(string identificacion)
        {

            return repositorioCliente.Buscar(identificacion);
        }

        public string Modificar(Cliente clienteViejo, Cliente clienteNuevo)
        {


            repositorioCliente.Modificar(clienteViejo, clienteNuevo);

            return "Modificacion Exitosa";
        }
    }
}
