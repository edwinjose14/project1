using CapaAccesoDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class ServicioEstilista
    {
        RepositorioEstilista repositorioEstilista = new RepositorioEstilista();

        public string Guardar(Estilista estilista)
        {

            if (repositorioEstilista.Buscar(estilista.Identificacion) == null)
            {
                repositorioEstilista.Guardar(estilista);
                return "El Estilista se guardo correctamente";
            }
            return "Error, no se puede guardar el Estilista";
        }

        public string Eliminar(Estilista estilista)
        {
            if (repositorioEstilista.Buscar(estilista.Identificacion) == null)
            {
                return "Error Al Eliminar  el Estilista" +
                    " tal Vez No exista";
            }

            repositorioEstilista.Eliminar(estilista);
            return "Eliminado exitoso";
        }

        public List<Estilista> Consultar()
        {
            return repositorioEstilista.Consultar();

        }

        public Estilista Buscar(string identificacion)
        {

            return repositorioEstilista.Buscar(identificacion);
        }

        public string Modificar(Estilista estilistaViejo, Estilista estilistaNuevo)
        {


            repositorioEstilista.Modificar(estilistaViejo, estilistaNuevo);

            return "Modificacion Exitosa";
        }

    }
}
