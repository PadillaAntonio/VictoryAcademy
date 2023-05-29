using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Conceptos
    {
        public List<Concepto> Listar()
        {
            List<Concepto> lista = new List<Concepto>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "Select conceptoid, conceptodescripcion, conceptotipo, conceptoreferenciaid from conceptos";
                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Concepto()
                            {
                                Id = Convert.ToInt32(dr["conceptoid"]),
                                Descripcion = dr["conceptodescripcion"].ToString().Trim(),
                                Tipo = Convert.ToInt32(dr["conceptotipo"]),
                                Referencia = Convert.ToInt32(dr["conceptoreferenciaid"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Concepto>();
                }
                return lista;
            }
        }
    }
}
