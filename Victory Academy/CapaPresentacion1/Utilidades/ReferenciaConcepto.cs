using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentacion1.Utilidades
{
    public class ReferenciaConcepto
    {
        public List<(int, string)> Listar(int id) 
        { 
            List<(int,string)> tuplas = new List<(int,string)>();
            switch (id)
            {
                case 1: // Tipo de programa
                    tuplas = ListaTipoPrograma();
                    break;
                case 2: // Tipo de Torneo
                    tuplas = ListaTipoTorneo();
                    break;
            }
            return tuplas;
        }

        // Tipo de programa
        private List<(int, string)> ListaTipoPrograma()
        {
            List<(int, string)> tuplas = new List<(int, string)>();
            List<TipoPrograma> Lista = new List<TipoPrograma>();
            CN_TipoProgramas obj_tipoPrograma = new CN_TipoProgramas();
            Lista = obj_tipoPrograma.Listar();
            if (Lista.Count > 0)
            {
                foreach(TipoPrograma tipo in Lista)
                {
                    tuplas.Add((tipo.Id, tipo.Descripcion));
                }
            }
            else
            {
                tuplas.Add((0, "Warning")); // Para cuando no hay nada cargado en tipo de programa
            }
            return tuplas;
        }

        private List<(int, string)> ListaTipoTorneo()
        {
            List<(int, string)> tuplas = new List<(int, string)>();
            (int, string) tupla = (0, "");
            List<TipoTorneo> Lista = new List<TipoTorneo>();
            CN_TipoTorneo obj_tipoTorneo = new CN_TipoTorneo();
            Lista = obj_tipoTorneo.Listar();
            if (Lista.Count > 0)
            {
                foreach (TipoTorneo tipo in Lista)
                {
                    tuplas.Add((tipo.Id, tipo.Descripcion));
                }
            }
            else
            {
                tuplas.Add((0, "Warning")); // Para cuando no hay nada cargado en tipo de programa
            }
            return tuplas;
        }
    }
}
