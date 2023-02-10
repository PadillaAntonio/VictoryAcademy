using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class FuncionesGenerales
    {
        public static string Encriptar(string entrada) 
        {
            string salida = string.Empty;
            byte[] encritpado = System.Text.Encoding.Unicode.GetBytes(entrada);
            salida = Convert.ToBase64String(encritpado);
            return salida;
        }
    }
}
