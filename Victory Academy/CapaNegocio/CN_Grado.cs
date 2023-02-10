using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Grado
    {
        private CD_Grados objcd_Grados = new CD_Grados();

        public List<Grado> Listar() 
        { 
            return objcd_Grados.Listar();
        }
    }
}
