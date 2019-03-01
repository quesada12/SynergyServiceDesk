using Entidades;
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
    public partial class AdminMenu : Form
    {
        Usuario usuario;

        public AdminMenu(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }


        private void AdminMenu_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = usuario.NombreUsuario;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void btnDepartamento_Click(object sender, EventArgs e)
        {
            CrearDepartamento nuevo = new CrearDepartamento(usuario);
            nuevo.Show();
            this.Close();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            CrearUsuario nuevo = new CrearUsuario(usuario);
            nuevo.Show();
            this.Close();
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            ActivarUsuario activar = new ActivarUsuario(usuario);
            activar.Show();
            this.Close();
        }

        private void btnInactivar_Click(object sender, EventArgs e)
        {
            InactivarUsuario inactivar = new InactivarUsuario(usuario);
            inactivar.Show();
            this.Close();
        }
    }
}
