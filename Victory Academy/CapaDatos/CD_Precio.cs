using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Precio
    {
        public List<ConceptoPrecio> Listar(int id)
        {
            List<ConceptoPrecio> lista = new List<ConceptoPrecio>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("Select conceptoid, conceptoprecioid,");
                    query.AppendLine(" trim(Cast(year(conceptopreciofecha) as char)) + '/' + trim(cast(month(conceptopreciofecha) as char)) ");
                    query.AppendLine(" + '/' + trim(cast(day(conceptopreciofecha) as char))");
                    query.AppendLine(" as Fecha, monedaid, conceptoprecionumero from conceptosprecio");
                    query.AppendLine(" where conceptoid = ");
                    query.AppendLine(id.ToString().Trim());
                    query.AppendLine(" order by conceptopreciofecha desc");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new ConceptoPrecio()
                            {
                                Id = Convert.ToInt32(dr["conceptoprecioid"]),
                                ConceptoId = Convert.ToInt32(dr["conceptoid"]),
                                Fecha = dr["Fecha"].ToString().Trim(),
                                MonedaId = Convert.ToInt32(dr["monedaid"]),
                                Valor = Convert.ToInt32(dr["conceptoprecionumero"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<ConceptoPrecio>();
                }
                return lista;
            }
        }
    }
}
