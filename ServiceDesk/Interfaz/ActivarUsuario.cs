using AccesoDatos;
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
    public partial class ActivarUsuario : Form
    {
        UsuarioLogica logica = new UsuarioLogica();
        List<Usuario> usuarios;
        Usuario usuario;

        public ActivarUsuario(Usuario usuario)
        {
            InitializeComponent();
            usuarios = BD.ObtenerUsuarios();
            this.usuario = usuario;
        }

        private void ActivarUsuario_Load(object sender, EventArgs e)
        {
            foreach (var u in usuarios)
            {
                if (u.Estado.Equals("I"))
                {
                    cbxUsuarios.Items.Add(u.Nombre+" "+u.Apellidos);
                }
            }
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            string seleccion = cbxUsuarios.SelectedItem.ToString();
            string[] nombre;
            nombre = seleccion.Split(' ');
            Usuario activar = logica.BuscarUsuario(nombre[0], nombre[1]);
            BD.ActivarUsuario(activar);
            MessageBox.Show("Usuario activado", "Usuario",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            AdminMenu menu = new AdminMenu(usuario);
            menu.Show();
            this.Close();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            AdminMenu menu = new AdminMenu(usuario);
            menu.Show();
            this.Close();
        }
    }
}
