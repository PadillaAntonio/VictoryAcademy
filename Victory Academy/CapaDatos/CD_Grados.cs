using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

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

        public string GetDescripcion(int id) 
        {
            string Descripcion = "";
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "Select gradodescripcion from grados where gradoid = @idgrado";
                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.Parameters.AddWithValue("@idgrado", id);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Descripcion = dr["gradodescripcion"].ToString().Trim();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Descripcion = string.Empty;
                }
            }
            return Descripcion;
        }

        public string Insertar(string descripcion) 
        {
            string Mensaje = string.Empty;
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_RegistraGrado", oconexion);
                    cmd.Parameters.AddWithValue("descripcion", descripcion);
                    cmd.Parameters.Add("resultado",SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar,500).Direction = ParameterDirection.Output;
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
                    SqlCommand cmd = new SqlCommand("SP_EditaGrado", oconexion);
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.Parameters.AddWithValue("descripcion", descripcion);
                    cmd.Parameters.Add("resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar,500).Direction = ParameterDirection.Output;
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
                    SqlCommand cmd = new SqlCommand("SP_EditaGrado", oconexion);
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
