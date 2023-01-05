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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        clsUsuarios oUsu = new clsUsuarios();

        private void button1_Click(object sender, EventArgs e)
        {
            oUsu.VerificarUsuario(txtusuario.Text, txtpassword.Text);
            if (oUsu.VerificarUsuario(txtusuario.Text, txtpassword.Text) == true)
            {
                MessageBox.Show("Bienvenido al sistema " + txtusuario.Text, "Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                frmPrincipal fp = new frmPrincipal();
                fp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario y/o Clave incorrecto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtusuario.Clear();
                txtpassword.Clear();
                txtusuario.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
