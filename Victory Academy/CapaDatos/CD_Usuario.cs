using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_Usuario
    {
        public List<Usuario> Listar()
        {
            List<Usuario> lista = new List<Usuario>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "Select usuarioid, usuarionick, usuariocontrasenia, personaid, usuarioesadmin from usuarios";
                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();
                    using(SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read()) 
                        {
                            lista.Add(new Usuario()
                            {
                                Id = Convert.ToInt32(dr["usuarioid"]),
                                Nick = dr["usuarionick"].ToString().Trim(),
                                Clave = dr["usuariocontrasenia"].ToString().Trim(),
                                PersonaId = Convert.ToInt32(dr["personaid"]),
                                EsAdmin = Convert.ToBoolean(dr["usuarioesadmin"])

                            });
                        }
                    }
                }
                catch(Exception ex) 
                {
                    lista = new List<Usuario>();
                }
                return lista;
            }
        }
    }
}
