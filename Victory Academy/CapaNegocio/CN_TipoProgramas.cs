using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_TipoProgramas
    {
        private CD_TipoPrograma objcd_TipoPrograma = new CD_TipoPrograma();

        public List<TipoPrograma> Listar()
        {
            return objcd_TipoPrograma.Listar();
        }

        public string Insertar(string descripcion)
        {
            return objcd_TipoPrograma.Insertar(descripcion);
        }

        public string Actualizar(int id, string descripcion)
        {
            return objcd_TipoPrograma.Actualizar(id, descripcion);
        }

        public string Eliminar(int id)
        {
            return objcd_TipoPrograma.Eliminar(id);
        }
    }
}
