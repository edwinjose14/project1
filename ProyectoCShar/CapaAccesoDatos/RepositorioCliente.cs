using CapaEntidad;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    public class RepositorioCliente
    {
        List<Cliente> clientes = new List<Cliente>();
        const string RutaCliente = "Lista Cliente.txt";

        public void Guardar(Cliente cliente)
        {

            FileStream ArchivoCliente = new FileStream(RutaCliente, FileMode.Append);
            StreamWriter escribir = new StreamWriter(ArchivoCliente);

            escribir.WriteLine($"{cliente.Identificacion}; {cliente.Nombre}; {cliente.Sexo};" +
                $" {cliente.Edad}; {cliente.Telefono}; {cliente.Ciudad}; {cliente.Direccion}");

            escribir.Close();
            ArchivoCliente.Close();

        }

        public void Eliminar(Cliente cliente)
        {

            clientes = Consultar();
            FileStream ArchivoCliente = new FileStream(RutaCliente, FileMode.Create);
            ArchivoCliente.Close();
            foreach (var item in clientes)
            {
                if (cliente.Identificacion != item.Identificacion)
                {
                    Guardar(item);
                }
            }

        }

        public List<Cliente> Consultar()
        {
            Cliente cliente = new Cliente();
            List<Cliente> clientes = new List<Cliente>();

            FileStream ArchivoCliente = new FileStream(RutaCliente, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader lector = new StreamReader(ArchivoCliente);

            string linea = string.Empty;

            while ((linea = lector.ReadLine()) != null)
            {
                cliente = Mapear(linea);
                clientes.Add(cliente);
            }

            lector.Close();
            ArchivoCliente.Close();
            return clientes;

        }

        public Cliente Buscar(string identificacion)
        {
            clientes = Consultar();

            return clientes.Where(p => p.Identificacion == identificacion).FirstOrDefault();
        }

        public void Modificar(Cliente clienteViejo, Cliente clienteNuevo)
        {

            clientes.Add(clienteNuevo);
            clientes.Remove(clienteViejo);

        }

        public Cliente Mapear(string linea)
        {
            Cliente recorrer = new Cliente();
            char partir = ';';

            string[] vectorCliente = linea.Split(partir);

            recorrer.Identificacion = vectorCliente[0];
            recorrer.Nombre = vectorCliente[1];
            recorrer.Sexo = vectorCliente[2];
            recorrer.Edad = Convert.ToInt16(vectorCliente[3]);
            recorrer.Telefono = vectorCliente[4];
            recorrer.Ciudad = vectorCliente[5];
            recorrer.Direccion = vectorCliente[6];

            return recorrer;
        }
    }
}
