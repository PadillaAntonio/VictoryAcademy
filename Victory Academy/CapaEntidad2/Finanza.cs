using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Finanza
    {
        public int Id { get; set; }
        public int PersonaId { get; set; }
        public int ConceptoId { get; set; }
        public string Fecha { get; set; }
    }
}
