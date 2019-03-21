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

namespace Interfaz.Administración_Usuarios
{
    public partial class EditarUsuario : Form
    {

        Usuario usuarioActual;
        Usuario edicion;
        List<Departamento> departamentos;
        UsuarioLogica logica = new UsuarioLogica();

        public EditarUsuario(Usuario usuarioActual, Usuario edicion)
        {
            InitializeComponent();
            departamentos = BD.ObtenerDepartamentos();
            this.usuarioActual = usuarioActual;
            this.edicion = edicion;
            txtNombre.Text = edicion.Nombre;
            txtApellidos.Text = edicion.Apellidos;
            txtTelefono.Text = edicion.Telefono;
            txtEmail.Text = edicion.Correo;
            cbxDepartamento.Text = edicion.Departamento;
            txtTipo.Text = edicion.Tipo_usuario;
         
            if (edicion.Estado.Equals("A"))
            {
                cbxEstado.Text = "Activo";
            }
            else
            {
                cbxEstado.Text = "Inactivo";
            }

            if (edicion.Tipo_usuario.Equals("Cliente"))
            {
               txtUsuario.Hide();
                txtContrasena.Hide();
                txtContrasena2.Hide();
                label8.Hide();
                label9.Hide();
                label10.Hide();
            }
            else
            {
                txtUsuario.Text = edicion.NombreUsuario;
                txtContrasena.Text = edicion.Contrasena;
                txtContrasena2.Text = edicion.Contrasena;
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (cbxDepartamento.SelectedItem == null)
            {
                if (cbxEstado.SelectedItem == null)
                {
                    logica.EditarUsuario(txtTelefono.Text, cbxDepartamento.Text, txtContrasena.Text, edicion.Estado, txtUsuario.Text);
                }
                else
                {
                    if (cbxEstado.SelectedItem.ToString().Equals("Activo")){
                        logica.EditarUsuario(txtTelefono.Text, cbxDepartamento.Text, txtContrasena.Text, "A", txtUsuario.Text);
                    }
                    else
                    {
                        logica.EditarUsuario(txtTelefono.Text, cbxDepartamento.Text, txtContrasena.Text, "I", txtUsuario.Text);
                    }
                    
                }
            }
            else
            {
                if (cbxEstado.SelectedItem == null)
                {
                    logica.EditarUsuario(txtTelefono.Text, cbxDepartamento.SelectedItem.ToString(), txtContrasena.Text, edicion.Estado, txtUsuario.Text);
                }
                else
                {
                    if (cbxEstado.SelectedItem.ToString().Equals("Activo"))
                    {
                        logica.EditarUsuario(txtTelefono.Text, cbxDepartamento.Text, txtContrasena.Text, "A", txtUsuario.Text);
                    }
                    else
                    {
                        logica.EditarUsuario(txtTelefono.Text, cbxDepartamento.Text, txtContrasena.Text, "I", txtUsuario.Text);
                    }
                }
            }

            

            ModificarUsuario modificar = new ModificarUsuario(usuarioActual);
            modificar.Show();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditarUsuario_Load(object sender, EventArgs e)
        {
            foreach (var d in departamentos)
            {
                cbxDepartamento.Items.Add(d.Nombre_departamento);
            }
            cbxEstado.Items.Add("Activo");

            cbxEstado.Items.Add("Inactivo");
        }
    }
}
