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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UsuarioLogica logica = new UsuarioLogica();
            int r=logica.Login(txtNombreUsuario.Text, txtContrasena.Text);
            switch (r)
            {
                case 0:
                    MessageBox.Show("Ingreso Correcto","Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    break;
                case 1:
                    MessageBox.Show("Usuario Inactivo", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNombreUsuario.Text = "";
                    txtContrasena.Text = "";
                    break;
                case 2:
                    MessageBox.Show("Contraseña incorrecta", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtContrasena.Text = "";
                    break;
                case 3:
                    MessageBox.Show("Usuario no existe", "Login", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtContrasena.Text = "";
                    txtNombreUsuario.Text = "";
                    break;

            }
        }
    }
}
