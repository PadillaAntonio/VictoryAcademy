using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class ConceptoPrecio
    {
        public int ConceptoId { get; set; }
        public int Id { get; set; }
        public string Fecha { get; set; }
        public int MonedaId { get; set; }
        public float Valor { get; set; }
    }
}
