using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Cliente:Persona
    {
        public string Ciudad { get; set; }
        public string Direccion { get; set; }
        public void AgregarCliente() { }

        public void EliminarCliente() { }
        public void ConsultarCliente() { }
        public void ModificarCliente() { }
    }
}
