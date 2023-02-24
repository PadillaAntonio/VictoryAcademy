using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Moneda
    {
        private CD_Moneda objcd_Moneda = new CD_Moneda();

        public List<Moneda> Listar()
        {
            return objcd_Moneda.Listar();
        }

        public string Insertar(string descripcion, string signo)
        {
            return objcd_Moneda.Insertar(descripcion, signo);
        }

        public string Actualizar(int id, string descripcion, string signo)
        {
            return objcd_Moneda.Actualizar(id, descripcion, signo);
        }

        public string Eliminar(int id)
        {
            return objcd_Moneda.Eliminar(id);
        }
    }
}
