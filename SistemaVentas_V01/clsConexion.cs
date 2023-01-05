using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace SistemaVentas_V01
{
    internal class clsConexion
    {
        protected SqlConnection Conectar()
        {
            SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["XCON"].ConnectionString);
            if (cnx.State == ConnectionState.Open)
            {
                cnx.Close();
            }
            else
            {
                cnx.Open();
            }
            return cnx;
        }
    }
}
