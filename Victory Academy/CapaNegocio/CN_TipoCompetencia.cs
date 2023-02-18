using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_TipoCompetencia
    {
        private CD_TipoCompetencia objcd_TipoCompetencia = new CD_TipoCompetencia();

        public List<TipoCompetencia> Listar()
        {
            return objcd_TipoCompetencia.Listar();
        }

        public string Insertar(string descripcion, int disciplina)
        {
            return objcd_TipoCompetencia.Insertar(descripcion, disciplina);
        }

        public string Actualizar(int id, string descripcion, int disciplina)
        {
            return objcd_TipoCompetencia.Actualizar(id, descripcion, disciplina);
        }

        public string Eliminar(int id)
        {
            return objcd_TipoCompetencia.Eliminar(id);
        }
    }
}
