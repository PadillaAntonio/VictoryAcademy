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
    public class CD_TipoTorneo
    {
        public List<TipoTorneo> Listar()
        {
            List<TipoTorneo> lista = new List<TipoTorneo>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "Select tipotorneoid, tipotorneodescripcion, tipotorneoprimerlugarpuntos, tipotorneosegundolugarpuntos, tipotorneotercerlugarpuntos from tipotorneo";
                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new TipoTorneo()
                            {
                                Id = Convert.ToInt32(dr["tipotorneoid"]),
                                Descripcion = dr["tipotorneodescripcion"].ToString().Trim(),
                                primerLugarPuntos = Convert.ToInt32(dr["tipotorneoprimerlugarpuntos"]),
                                segundoLugarPuntos = Convert.ToInt32(dr["tipotorneosegundolugarpuntos"]),
                                tercerLugarPuntos = Convert.ToInt32(dr["tipotorneotercerlugarpuntos"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<TipoTorneo>();
                }
                return lista;
            }
        }

        public string Insertar(string descripcion, int puntos1, int puntos2, int puntos3)
        {
            string Mensaje = string.Empty;
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_RegistraTipoTorneo", oconexion);
                    cmd.Parameters.AddWithValue("descripcion", descripcion);
                    cmd.Parameters.AddWithValue("puntos1", puntos1);
                    cmd.Parameters.AddWithValue("puntos2", puntos2);
                    cmd.Parameters.AddWithValue("puntos3", puntos3);
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

        public string Actualizar(int id, string descripcion, int puntos1, int puntos2, int puntos3)
        {
            string Mensaje = string.Empty;
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_EditaTipoTorneo", oconexion);
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.Parameters.AddWithValue("descripcion", descripcion);
                    cmd.Parameters.AddWithValue("puntos1", puntos1);
                    cmd.Parameters.AddWithValue("puntos2", puntos2);
                    cmd.Parameters.AddWithValue("puntos3", puntos3);
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
                    SqlCommand cmd = new SqlCommand("SP_EliminaTipoTorneo", oconexion);
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
