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
    public partial class frmConsultadetalle_venta : Form
    {
        public frmConsultadetalle_venta()
        {
            InitializeComponent();
        }
        clsBoletaVenta oventa = new clsBoletaVenta();
        private void btnmostrar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = oventa.consultadetalle_venta(textBox1.Text);
            dataGridView1.DataSource = dt;
        }
    }
}
