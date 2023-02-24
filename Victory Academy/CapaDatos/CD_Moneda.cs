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
    public class CD_Moneda
    {
        public List<Moneda> Listar()
        {
            List<Moneda> lista = new List<Moneda>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "select monedaid, monedadescripcion, monedasigno from monedas";
                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Moneda()
                            {
                                Id = Convert.ToInt32(dr["monedaid"]),
                                Descripcion = dr["monedadescripcion"].ToString().Trim(),
                                Signo = dr["monedasigno"].ToString().Trim()
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Moneda>();
                }
                return lista;
            }
        }


        public string Insertar(string descripcion, string signo)
        {
            string Mensaje = string.Empty;
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_RegistraMoneda", oconexion);
                    cmd.Parameters.AddWithValue("descripcion", descripcion);
                    cmd.Parameters.AddWithValue("signo", signo);
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

        public string Actualizar(int id, string descripcion, string signo)
        {
            string Mensaje = string.Empty;
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_EditaMoneda", oconexion);
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.Parameters.AddWithValue("descripcion", descripcion);
                    cmd.Parameters.AddWithValue("signo", signo);
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
                    SqlCommand cmd = new SqlCommand("SP_EliminaMoneda", oconexion);
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
