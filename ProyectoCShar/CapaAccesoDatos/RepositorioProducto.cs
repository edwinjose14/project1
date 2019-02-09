using CapaEntidad;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    public class RepositorioProducto
    {
        List<Producto> productos = new List<Producto>();
        const string RutaProductos = @"E:\ProyectoCShar\Lista de Productos\Lista Productos.txt";

        public void Guardar(Producto producto) {

            FileStream ArchivoProductos = new FileStream(RutaProductos, FileMode.Append);
            StreamWriter escribir = new StreamWriter(ArchivoProductos);

            escribir.WriteLine($"{producto.Nit}; {producto.Nombre}; {producto.Marca};" +
                $" {producto.Cantidad}; {producto.ValorUnitario}");

            escribir.Close();
            ArchivoProductos.Close();
    
        }

        public void Eliminar(Producto producto) {

            productos = Consultar();
            FileStream ArchivoProducto = new FileStream(RutaProductos, FileMode.Create);
            ArchivoProducto.Close();
            foreach (var item in productos)
            {
                if (producto.Nit != item.Nit)
                {
                    Guardar(item);
                }
            }

        }

        public List<Producto> Consultar() {
            Producto producto = new Producto();
            List<Producto> productos = new List<Producto>();

            FileStream ArchivoProductos = new FileStream(RutaProductos, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader lector = new StreamReader(ArchivoProductos);

            string linea = string.Empty;

            while ((linea = lector.ReadLine()) != null)
            {
                producto = Mapear(linea);
                productos.Add(producto);
            }

            lector.Close();
            ArchivoProductos.Close();
            return productos;

        }

        public Producto Buscar(string nit) {
            productos = Consultar();

            return productos.Where(p=>p.Nit ==nit).FirstOrDefault();
        }

        public void Modificar(Producto productoviejo, Producto productonuevo) {

            productos.Add(productonuevo);
            productos.Remove(productoviejo);

        }

        public Producto Mapear(string linea) {
            Producto recorrer = new Producto();
            char partir = ';';

            string[] vectorProducto = linea.Split(partir);

            recorrer.Nit = vectorProducto[0];
            recorrer.Nombre = vectorProducto[1];
            recorrer.Marca = vectorProducto[2];
            recorrer.Cantidad = Convert.ToInt16(vectorProducto[3]);
            recorrer.ValorUnitario = Convert.ToDouble(vectorProducto[4]);

            return recorrer;
        }
    }
}
