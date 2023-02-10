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
    public class CD_Grados
    {
        public List<Grado> Listar()
        {
            List<Grado> lista = new List<Grado>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "Select gradoid, gradodescripcion from grados";
                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Grado()
                            {
                                Id = Convert.ToInt32(dr["gradoid"]),
                                Descripcion = dr["gradodescripcion"].ToString().Trim()
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Grado>();
                }
                return lista;
            }
        }
    }
}
