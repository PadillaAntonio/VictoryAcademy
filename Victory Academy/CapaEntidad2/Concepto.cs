using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Concepto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int Tipo { get; set; }
        public int Referencia { get; set; }
    }
}
