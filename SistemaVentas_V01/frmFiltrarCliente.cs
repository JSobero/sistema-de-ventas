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
    public partial class frmFiltrarCliente : Form
    {
        public frmFiltrarCliente()
        {
            InitializeComponent();
        }

        clsBoletaVenta obol = new clsBoletaVenta();

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtbuscar.Text))
            {
                MessageBox.Show("Ingrese apellido a buscar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtbuscar.Focus();
                return;
            }
            else
            {
                this.dataGridView1.DataSource = obol.filtrarClientes(txtbuscar.Text);
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            frmBoletaVenta bolVenta = Owner as frmBoletaVenta;
            bolVenta.txtcodcli.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            bolVenta.txtruc.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            bolVenta.txtrazonsocial.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            this.Hide();
            bolVenta.Show();
        }
    }
}
