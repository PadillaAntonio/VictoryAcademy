using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_TipoTelefono
    {
        private CD_TiposTelefonos objCD_TipoTelefono = new CD_TiposTelefonos();

        public List<TipoTelefono> Listar()
        {
            return objCD_TipoTelefono.Listar();
        }

        public string Insertar(string descripcion)
        {
            return objCD_TipoTelefono.Insertar(descripcion);
        }

        public string Actualizar(int id, string descripcion)
        {
            return objCD_TipoTelefono.Actualizar(id, descripcion);
        }

        public string Eliminar(int id)
        {
            return objCD_TipoTelefono.Eliminar(id);
        }
    }
}
