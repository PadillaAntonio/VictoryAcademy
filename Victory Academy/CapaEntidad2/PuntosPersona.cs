using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class PuntosPersona
    {
        public int TorneoId { get; set; }
        public int PersonaId { get; set; }
        public int TipoCompetenciaId { get; set; }
        public bool PrimerLugar { get; set; }
        public bool SegundoLugar { get; set; }
        public bool TercerLugar { get; set; }
        public bool Competencia { get; set; }
    }
}
