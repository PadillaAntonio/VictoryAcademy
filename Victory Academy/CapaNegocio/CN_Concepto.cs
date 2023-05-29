using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Concepto
    {
        private CD_Conceptos objcd_Concepto = new CD_Conceptos();

        public List<Concepto> Listar()
        {
            return objcd_Concepto.Listar();
        }
    }
}
