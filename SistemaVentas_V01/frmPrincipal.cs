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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes cliente = new frmClientes();
            cliente.MdiParent = this;
            cliente.Show();

        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductos producto = new frmProductos();
            producto.MdiParent = this;
            producto.Show();
        }

        private void boletaDeVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBoletaVenta boletaventa = new frmBoletaVenta();
            boletaventa.MdiParent = this;
            boletaventa.Show();
        }

        private void ventasPorFechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaVentas frmconsulta = new frmConsultaVentas();
            frmconsulta.MdiParent = this;
            frmconsulta.Show();
        }

        private void detalleVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultadetalle_venta frmconsultadtVenta = new frmConsultadetalle_venta();
            frmconsultadtVenta.MdiParent = this;
            frmconsultadtVenta.Show();
        }
    }
}
