using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace SistemaVentas_V01
{
    internal class clsClientes: clsConexion
    {
        public void RegistrarClientes(String ruc, String ape, String nom, String tel)
        {
            SqlCommand cmd = new SqlCommand("pa_insertarClientes",Conectar());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ruc",ruc);
            cmd.Parameters.AddWithValue("@ape", ape);
            cmd.Parameters.AddWithValue("@nom", nom);
            cmd.Parameters.AddWithValue("@tel", tel);
            cmd.ExecuteNonQuery();
        }

        public DataTable BuscarClientes(String ape)
        {
            SqlDataAdapter da = new SqlDataAdapter("pa_buscar_Clientes",Conectar());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@ape", ape);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void ActualizarClientes(int cod, String ruc, String ape, String nom, String tel)
        {
            SqlCommand cmd = new SqlCommand("pa_actualizar_Clientes", Conectar());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cod", cod);
            cmd.Parameters.AddWithValue("@ruc", ruc);
            cmd.Parameters.AddWithValue("@ape", ape);
            cmd.Parameters.AddWithValue("@nom", nom);
            cmd.Parameters.AddWithValue("@tel", tel);
            cmd.ExecuteNonQuery();
        }

        public void EliminarClientes(int cod)
        {
            SqlCommand cmd = new SqlCommand("pa_Eliminar_Clientes", Conectar());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cod", cod);
            cmd.ExecuteNonQuery();
        }
    }
}
