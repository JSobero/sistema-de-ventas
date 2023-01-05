using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaVentas_V01
{
    internal class clsProducto: clsConexion
    {
        public DataTable LlenarCategoria()
        {
            SqlDataAdapter da = new SqlDataAdapter("select idcategoria,nombres from categorias",Conectar());
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void registrarProducto(String nom,int idcat,int cant,double pu,PictureBox foto)
        {
            SqlCommand cmd = new SqlCommand("pa_registrarproducto",Conectar());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nom", nom);
            cmd.Parameters.AddWithValue("@cat", idcat);
            cmd.Parameters.AddWithValue("@cant", cant);
            cmd.Parameters.AddWithValue("@pu", pu);
            cmd.Parameters.AddWithValue("@foto", SqlDbType.Image);
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            foto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            cmd.Parameters["@foto"].Value=ms.GetBuffer();
            cmd.ExecuteNonQuery();
        }

        public DataTable MostrarProductosRegistrados()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT idpro,p.descripcion,c.nombres as Categoría,cantidad,repcio as Precio,foto as Foto FROM PRODUCTOS p inner join categorias c on p.idcategoria=c.idcategoria", Conectar());
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable BuscarProductoNombre(String nom)
        {
            SqlCommand cmd = new SqlCommand("PA_BUSCAR_PRODUCTO_NOMBRE", Conectar());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NOM",nom);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void ActualizarProducto(int cod,String nom, int idcat, int cant, double pu, PictureBox foto)
        {
            SqlCommand cmd = new SqlCommand("pa_Actualziarproducto", Conectar());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cod", cod);
            cmd.Parameters.AddWithValue("@nom", nom);
            cmd.Parameters.AddWithValue("@cat", idcat);
            cmd.Parameters.AddWithValue("@cant", cant);
            cmd.Parameters.AddWithValue("@pu", pu);
            cmd.Parameters.AddWithValue("@foto", SqlDbType.Image);
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            foto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            cmd.Parameters["@foto"].Value = ms.GetBuffer();
            cmd.ExecuteNonQuery();
        }

        public void EliminarProducto(int cod)
        {
            SqlCommand cmd = new SqlCommand("pa_Eliminar_producto", Conectar());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cod", cod);
            cmd.ExecuteNonQuery();
        }
    }
}
