using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace SistemaVentas_V01
{
    internal class clsBoletaVenta: clsConexion
    {
        public DataTable GenerarNumBoletaVenta()
        {
            SqlDataAdapter da = new SqlDataAdapter("PA_GENERARNUMBOLETA",Conectar());
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable filtrarClientes(String ape)
        {
            SqlDataAdapter da = new SqlDataAdapter("pa_filtrar_clienes",Conectar());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@ape",ape);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable filtrarProducto(String nompro)
        {
            SqlDataAdapter da = new SqlDataAdapter("pa_filtrar_productos", Conectar());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@prod", nompro);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void RegistrarBoletaCebecera(String num, DateTime fechaventa, int codcli)
        {
            SqlCommand cmd = new SqlCommand("pa_registrarCabeceraBoleta",Conectar());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@numbol",num);
            cmd.Parameters.AddWithValue("@fechavent", fechaventa);
            cmd.Parameters.AddWithValue("@cocli", codcli);
            cmd.ExecuteNonQuery();
        }

        public void RegistrarDetalleBoleta(String num, int codpro, String desc, int cant, 
            double pu, double import, double subtotal, double igv, double total)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("pa_registrarDetalleBoleta", Conectar());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@numbol", num);
                cmd.Parameters.AddWithValue("@codpro", codpro);
                cmd.Parameters.AddWithValue("@desc", desc);
                cmd.Parameters.AddWithValue("@cantidad", cant);
                cmd.Parameters.AddWithValue("@pu", pu);
                cmd.Parameters.AddWithValue("@importe", import);
                cmd.Parameters.AddWithValue("@subtotal", subtotal);
                cmd.Parameters.AddWithValue("@igv", igv);
                cmd.Parameters.AddWithValue("@total", total);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                return;
            }
            
        }

        public DataTable ConsultarVentasFecha(DateTime f1, DateTime f2)
        {
            SqlCommand cmd = new SqlCommand("pa_consultaVentas", Conectar());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Parameters.AddWithValue("@fecha1",f1);
            cmd.Parameters.AddWithValue("@fecha2",f2);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable consultadetalle_venta(String numVenta)
        {
            SqlCommand cmd = new SqlCommand("pa_consultaadetallesventas", Conectar());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Parameters.AddWithValue("@numbol", numVenta);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

    }
}
