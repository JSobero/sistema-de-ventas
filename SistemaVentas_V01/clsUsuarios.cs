using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace SistemaVentas_V01
{
    internal class clsUsuarios: clsConexion
    {
        public Boolean VerificarUsuario(String nomUsu,String clave)
        {
            SqlCommand cmd = new SqlCommand("pa_acceso_sistema", Conectar());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nomusu",nomUsu);
            cmd.Parameters.AddWithValue("@clave",clave);
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.HasRows == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
