using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Torneo
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int tipoTorneoId { get; set; }
        public string Fecha { get; set; }
    }
}
