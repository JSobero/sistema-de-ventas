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
    public partial class frmBoletaVenta : Form
    {
        public frmBoletaVenta()
        {
            InitializeComponent();
        }

        clsBoletaVenta obol = new clsBoletaVenta();

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtfechaventa.Text = DateTime.Now.ToShortDateString();
        }

        private void btnnuevaventa_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = obol.GenerarNumBoletaVenta();
            txtnumbol.Text = dt.Rows[0][0].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmFiltrarCliente cli = new frmFiltrarCliente();
            AddOwnedForm(cli);
            cli.ShowDialog();
        }

        private void txtproducto_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtproducto.Text))
            {
                MessageBox.Show("Ingrese el nombre del producto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtproducto.Focus();
                return;
            }
            else
            {
                DataTable dt = new DataTable();
                dt = obol.filtrarProducto(txtproducto.Text);
                txtcantidad.Focus();
                if (dt.Rows.Count > 0)
                {
                    txtcodprod.Text = dt.Rows[0][0].ToString();
                    txtproducto.Text = dt.Rows[0][1].ToString();
                    txtpreciounit.Text = dt.Rows[0][2].ToString();
                    txtcantidad.Text = dt.Rows[0][3].ToString();
                }
            }


        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            double importe, pu, cant, igv = 0, total = 0;
            if (string.IsNullOrEmpty(txtcantidad.Text))
            {
                MessageBox.Show("Ingrese la cantidad a comprar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtcantidad.Focus();
                return;
            }

            pu = Convert.ToDouble(txtpreciounit.Text);
            cant = Convert.ToInt32(txtcantidad.Text);
            importe = pu * cant;

            double sumatoria = 0;

            dataGridView1.Rows.Add(txtcodprod.Text,txtproducto.Text, txtcantidad.Text, txtpreciounit.Text, importe);
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                sumatoria += Convert.ToInt32(row.Cells[4].Value);
            }

            igv = sumatoria * 18 / 100;
            total = sumatoria + igv;

            txtsubtotal.Text = sumatoria.ToString();
            txtigv.Text = igv.ToString();
            txttotal.Text = total.ToString();
        }

        private void btnregistrarventa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtnumbol.Text))
            {
                MessageBox.Show("No olvide generar la venta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btnnuevaventa.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtcodcli.Text))
            {
                MessageBox.Show("No olvide seleccionar al cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtcodcli.Focus();
                return;
            }

            obol.RegistrarBoletaCebecera(txtnumbol.Text, Convert.ToDateTime(txtfechaventa.Text), 
                Convert.ToInt32(txtcodcli.Text));
            MessageBox.Show("Venta realizada satisfactoriamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                obol.RegistrarDetalleBoleta(Convert.ToString(txtnumbol.Text),
                    Convert.ToInt32(row.Cells["colitem"].Value),
                    Convert.ToString(row.Cells["colproducto"].Value),
                    Convert.ToInt32(row.Cells["colcantidad"].Value),
                    Convert.ToDouble(row.Cells["colprecio"].Value),

                    Convert.ToDouble(row.Cells["colimporte"].Value),
                    Convert.ToDouble(txtsubtotal.Text),
                    Convert.ToDouble(txtigv.Text),
                    Convert.ToDouble(txttotal.Text));
            }
        }

        private void frmBoletaVenta_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = obol.GenerarNumBoletaVenta();
            txtnumbol.Text = dt.Rows[0][0].ToString();
        }

        private void btnquitar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(0);
            txtsubtotal.Clear();
            txtigv.Clear();
            txttotal.Clear();
            txtcantidad.Focus();
        }
    }
}
