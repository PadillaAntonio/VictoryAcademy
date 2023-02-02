using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nick { get; set; }
        public string Clave { get; set; }
        public int PersonaId { get; set; }
        public bool EsAdmin { get; set; }
    }
}
