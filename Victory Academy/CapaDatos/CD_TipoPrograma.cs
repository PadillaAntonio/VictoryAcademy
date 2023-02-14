using CapaEntidad;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_TipoPrograma
    {
        public List<TipoPrograma> Listar()
        {
            List<TipoPrograma> lista = new List<TipoPrograma>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "Select tipoprogramaid, tipoprogramadescripcion from tipoprogramas";
                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new TipoPrograma()
                            {
                                Id = Convert.ToInt32(dr["tipoprogramaid"]),
                                Descripcion = dr["tipoprogramadescripcion"].ToString().Trim()
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<TipoPrograma>();
                }
                return lista;
            }
        }

        public string Insertar(string descripcion)
        {
            string Mensaje = string.Empty;
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_RegistraTipoPrograma", oconexion);
                    cmd.Parameters.AddWithValue("descripcion", descripcion);
                    cmd.Parameters.Add("resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();
                    cmd.ExecuteNonQuery();
                    Mensaje = cmd.Parameters["mensaje"].Value.ToString().Trim();
                }
            }
            catch (Exception ex)
            {
                Mensaje = ex.Message;
            }
            return Mensaje;
        }

        public string Actualizar(int id, string descripcion)
        {
            string Mensaje = string.Empty;
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_EditaTipoPrograma", oconexion);
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.Parameters.AddWithValue("descripcion", descripcion);
                    cmd.Parameters.Add("resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();
                    cmd.ExecuteNonQuery();
                    Mensaje = cmd.Parameters["mensaje"].Value.ToString().Trim();
                }
            }
            catch (Exception ex)
            {
                Mensaje = ex.Message;
            }
            return Mensaje;
        }

        public string Eliminar(int id)
        {
            string Mensaje = string.Empty;
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_EliminaTipoPrograma", oconexion);
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.Parameters.Add("resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();
                    cmd.ExecuteNonQuery();
                    Mensaje = cmd.Parameters["mensaje"].Value.ToString().Trim();
                }
            }
            catch (Exception ex)
            {
                Mensaje = ex.Message;
            }
            return Mensaje;
        }
    }
}
