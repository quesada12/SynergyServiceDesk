using Entidades;
using LogicaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UsuarioLogica logica = new UsuarioLogica();
            Usuario actual = logica.Login(txtNombreUsuario.Text, txtContrasena.Text);
            if (actual == null)
            {
                MessageBox.Show("Datos erróneos", "Login", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtContrasena.Text = "";
                txtNombreUsuario.Text = "";
            }
            else if (actual.Estado.Equals("A"))
            {
                MessageBox.Show("Ingreso Correcto", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AdminMenu menu = new AdminMenu(actual);
                menu.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario Inactivo", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombreUsuario.Text = "";
                txtContrasena.Text = "";

            }



        }
    }
}
