using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string FechaNacimiento { get; set; }

        public string Domicilio { get; set; }
        public string Barrio { get; set; }
        public string Email { get; set; }
        public string CI { get; set; }
        public string Digito { get; set; }
        public int gradoId { get; set; }
        public int tipoprogramaid { get; set; }
    }
}
