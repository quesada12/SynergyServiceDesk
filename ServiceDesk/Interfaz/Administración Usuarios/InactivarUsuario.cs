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
    public partial class InactivarUsuario : Form
    {
        UsuarioLogica logica = new UsuarioLogica();
        List<Usuario> usuarios;
        Usuario usuario;

        public InactivarUsuario(Usuario usuario)
        {
            InitializeComponent();
            usuarios = BD.ObtenerUsuarios();
            this.usuario = usuario;
        }

        private void InactivarUsuario_Load(object sender, EventArgs e)
        {
            foreach (var u in usuarios)
            {
                if (u.Estado.Equals("A"))
                {
                    
                        cbxUsuarios.Items.Add(u.Nombre + " " + u.Apellidos);
                    
                    
                }
            }
        }

        private void btnInactivar_Click(object sender, EventArgs e)
        {
            string seleccion = cbxUsuarios.SelectedItem.ToString();
            string[] nombre;
            nombre = seleccion.Split(' ');
            Usuario inactivar = logica.BuscarUsuario(nombre[0], nombre[1]);
            //BD.InactivarUsuario(inactivar);
            MessageBox.Show("Usuario inactivado", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //AdminMenu menu = new AdminMenu(usuario);
            //menu.Show();
            this.Close();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            //AdminMenu menu = new AdminMenu(usuario);
            //menu.Show();
            this.Close();
        }
    }
}
