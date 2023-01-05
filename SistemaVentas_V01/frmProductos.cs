using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentas_V01
{
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();

            llenarComboCategoria();
            mostrarProductoregistrado();
        }

        clsProducto oprod = new clsProducto();

        private void llenarComboCategoria()
        {
            DataTable dt = new DataTable();
            dt = oprod.LlenarCategoria();
            cboCategoria.DataSource = dt;
            cboCategoria.DisplayMember = "nombres";
            cboCategoria.ValueMember = "idcategoria";
        }

        private void btncargarfoto_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.ShowDialog();
                if (openFileDialog1.FileName.Equals("") == false)
                {
                    pictureBox1.Load(openFileDialog1.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar la imagen" + ex.Message);
            }
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

            oprod.registrarProducto(txtnombre.Text,
                Convert.ToInt32(cboCategoria.SelectedValue), Convert.ToInt32(txtcant.Text), Convert.ToDouble(txtpu.Text),pictureBox1);
            mostrarProductoregistrado();
        }

        private void mostrarProductoregistrado()
        {
            dataGridView1.DataSource = oprod.MostrarProductosRegistrados();
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = oprod.BuscarProductoNombre(txtbuscar.Text);
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                txtcod.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtnombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                cboCategoria.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtcant.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtpu.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

            oprod.ActualizarProducto(Convert.ToInt32(txtcod.Text),txtnombre.Text,
                Convert.ToInt32(cboCategoria.SelectedValue), Convert.ToInt32(txtcant.Text), Convert.ToDouble(txtpu.Text), pictureBox1);
            mostrarProductoregistrado();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            oprod.EliminarProducto(Convert.ToInt32(txtcod.Text));
            mostrarProductoregistrado();
            txtcod.Clear();
            txtnombre.Clear();
            txtcant.Clear();
            txtpu.Clear();
        }
    }
}
