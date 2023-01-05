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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        clsClientes ocli = new clsClientes();

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            if(txtruc.Text.Equals("") || txtapellidos.Equals(""))
            {
                MessageBox.Show("No olvide ingresar los datos para registrar", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtruc.Focus();
                return;
            }
            else
            {
                ocli.RegistrarClientes(txtruc.Text,txtapellidos.Text,txtnombres.Text,txttelefono.Text);
                MessageBox.Show("Clientes registrados correctamente");
                limpiarTexto();
            }
        }

        private void limpiarTexto()
        {
            txtbuscar.Clear();
            txtcodigo.Clear();
            txtruc.Clear();
            txtapellidos.Clear();
            txtnombres.Clear();
            txttelefono.Clear();
            txtruc.Focus();
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = ocli.BuscarClientes(txtbuscar.Text);
            this.dataGridView1.DataSource = dt;
            lbltotal.Text = "Cantidad de clientes son: " + dt.Rows.Count;
            if (dt.Rows.Count > 0)
            {
                txtcodigo.Text = dt.Rows[0][0].ToString();
                txtruc.Text = dt.Rows[0][1].ToString();
                txtapellidos.Text = dt.Rows[0][2].ToString();
                txtnombres.Text = dt.Rows[0][3].ToString();
                txttelefono.Text = dt.Rows[0][4].ToString();
            }
            else
            {
                txtcodigo.Text = "";
                txtruc.Text = "";
                txtapellidos.Text = "";
                txtnombres.Text = "";
                txttelefono.Text = "";
            }
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            if (txtcodigo.Text.Equals("") || txtruc.Equals("") || txtapellidos.Equals(""))
            {
                MessageBox.Show("No olvide seleccionar una fila para actualizar", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtruc.Focus();
                return;
            }
            else
            {
                ocli.ActualizarClientes(Convert.ToInt32(txtcodigo.Text),txtruc.Text, txtapellidos.Text, txtnombres.Text, txttelefono.Text);
                MessageBox.Show("Datos del Cliente se actualizo correctamente");
                limpiarTexto();
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (txtcodigo.Text.Equals(""))
            {
                MessageBox.Show("Debe seleccionar una fila para eliminar", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtruc.Focus();
                return;
            }
            else
            {
                ocli.EliminarClientes(Convert.ToInt32(txtcodigo.Text));
                MessageBox.Show("Datos del Cliente se eliminaron");
                limpiarTexto();
            }
        }
    }
}
