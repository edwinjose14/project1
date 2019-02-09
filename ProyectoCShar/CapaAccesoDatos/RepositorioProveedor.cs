using CapaEntidad;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    public class RepositorioProveedor
    {
        List<Proveedor> proveedores = new List<Proveedor>();
        const string RutaProveedores = "Lista Proveedores.txt";

        public void Guardar(Proveedor proveedor)
        {

            FileStream ArchivoProveedores = new FileStream(RutaProveedores, FileMode.Append);
            StreamWriter escribir = new StreamWriter(ArchivoProveedores);

            escribir.WriteLine($"{proveedor.Nit}; {proveedor.Nombre}; {proveedor.Telefono};" +
                $" {proveedor.Direccion}; {proveedor.Ciudad}");

            escribir.Close();
            ArchivoProveedores.Close();

        }

        public void Eliminar(Proveedor proveedor)
        {

            proveedores = Consultar();
            FileStream ArchivoProducto = new FileStream(RutaProveedores, FileMode.Create);
            ArchivoProducto.Close();
            foreach (var item in proveedores)
            {
                if (proveedor.Nit != item.Nit)
                {
                    Guardar(item);
                }
            }

        }

        public List<Proveedor> Consultar()
        {
            Proveedor proveedor = new Proveedor();
            List<Proveedor> productos = new List<Proveedor>();

            FileStream ArchivoProveedor = new FileStream(RutaProveedores, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader lector = new StreamReader(ArchivoProveedor);

            string linea = string.Empty;

            while ((linea = lector.ReadLine()) != null)
            {
                proveedor = Mapear(linea);
                proveedores.Add(proveedor);
            }

            lector.Close();
            ArchivoProveedor.Close();
            return productos;

        }

        public Proveedor Buscar(string nit)
        {
            proveedores = Consultar();

            return proveedores.Where(p => p.Nit == nit).FirstOrDefault();
        }

        public void Modificar(Proveedor proveedorViejo, Proveedor proveedorNuevo)
        {

            proveedores.Add(proveedorNuevo);
            proveedores.Remove(proveedorViejo);

        }

        public Proveedor Mapear(string linea)
        {
            Proveedor recorrer = new Proveedor();
            char partir = ';';

            string[] vectorProveedor = linea.Split(partir);

            recorrer.Nit = vectorProveedor[0];
            recorrer.Nombre = vectorProveedor[1];
            recorrer.Telefono = vectorProveedor[2];
            recorrer.Direccion = vectorProveedor[3];
            recorrer.Ciudad = vectorProveedor[4];

            return recorrer;
        }
    }
}
