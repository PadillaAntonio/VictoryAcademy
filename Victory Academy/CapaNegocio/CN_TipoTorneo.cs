using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_TipoTorneo
    {
        private CD_TipoTorneo objcd_TipoTorneo = new CD_TipoTorneo();
        public List<TipoTorneo> Listar()
        {
            return objcd_TipoTorneo.Listar();
        }

        public string Insertar(string descripcion, int puntos1, int puntos2, int puntos3)
        {
            return objcd_TipoTorneo.Insertar(descripcion, puntos1, puntos2, puntos3);
        }

        public string Actualizar(int id, string descripcion, int puntos1, int puntos2, int puntos3)
        {
            return objcd_TipoTorneo.Actualizar(id, descripcion, puntos1, puntos2, puntos3);
        }

        public string Eliminar(int id)
        {
            return objcd_TipoTorneo.Eliminar(id);
        }
    }
}
