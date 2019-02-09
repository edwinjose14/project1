using CapaEntidad;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    public class RepositorioEstilista
    {
        List<Estilista> estilistas = new List<Estilista>();
        const string RutaEstilista = "Lista Estilista.txt";

        public void Guardar(Estilista estilista)
        {

            FileStream ArchivoEstilista = new FileStream(RutaEstilista, FileMode.Append);
            StreamWriter escribir = new StreamWriter(ArchivoEstilista);

            escribir.WriteLine($"{estilista.Identificacion}; {estilista.Nombre}; {estilista.Sexo};" +
                $" {estilista.Edad}; {estilista.Telefono}");

            escribir.Close();
            ArchivoEstilista.Close();

        }

        public void Eliminar(Estilista estilista)
        {

            estilistas = Consultar();
            FileStream ArchivoEstilista = new FileStream(RutaEstilista, FileMode.Create);
            ArchivoEstilista.Close();
            foreach (var item in estilistas)
            {
                if (estilista.Identificacion != item.Identificacion)
                {
                    Guardar(item);
                }
            }

        }

        public List<Estilista> Consultar()
        {
            Estilista estilista = new Estilista();
            List<Estilista> estilistas = new List<Estilista>();

            FileStream ArchivoEstilista = new FileStream(RutaEstilista, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader lector = new StreamReader(ArchivoEstilista);

            string linea = string.Empty;

            while ((linea = lector.ReadLine()) != null)
            {
                estilista = Mapear(linea);
                estilistas.Add(estilista);
            }

            lector.Close();
            ArchivoEstilista.Close();
            return estilistas;

        }

        public Estilista Buscar(string identificacion)
        {
            estilistas = Consultar();

            return estilistas.Where(p => p.Identificacion == identificacion).FirstOrDefault();
        }

        public void Modificar(Estilista estilistaViejo, Estilista estilistaNuevo)
        {

            estilistas.Add(estilistaNuevo);
            estilistas.Remove(estilistaViejo);

        }

        public Estilista Mapear(string linea)
        {
            Estilista recorrer = new Estilista();
            char partir = ';';

            string[] vectorEstilista = linea.Split(partir);

            recorrer.Identificacion = vectorEstilista[0];
            recorrer.Nombre = vectorEstilista[1];
            recorrer.Sexo = vectorEstilista[2];
            recorrer.Edad = Convert.ToInt16(vectorEstilista[3]);
            recorrer.Telefono = vectorEstilista[4];

            return recorrer;
        }
    }
}
