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
    public partial class CrearUsuario : Form
    {
        UsuarioLogica logica = new UsuarioLogica();
        List<Departamento> departamentos;
        Usuario usuario;

        public CrearUsuario(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            departamentos = BD.ObtenerDepartamentos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

        private void CrearUsuario_Load(object sender, EventArgs e)
        {
            foreach (var d in departamentos)
            {
                cbxDepartamento.Items.Add(d.Nombre_departamento);
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtApellidos.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtTelefono.Text))
            {
                MessageBox.Show("Datos erroneos", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContrasena.Text = "";
                txtContrasena2.Text = "";
            }
            else
            {
                if (cbxTipo.SelectedItem.ToString().Equals("Tecnico") || cbxTipo.SelectedItem.ToString().Equals("Administrador"))
                {
                    if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtContrasena.Text))
                    {
                        MessageBox.Show("Datos erroneos", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtContrasena.Text = "";
                        txtContrasena2.Text = "";
                    }
                    else
                    {
                        if (txtContrasena.Text != txtContrasena2.Text)
                        {
                            MessageBox.Show("Contraseñas no coinciden", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtContrasena.Text = "";
                            txtContrasena2.Text = "";
                        }
                        else
                        {
                            if (cbxTipo.SelectedItem.ToString().Equals("Cliente"))
                            {
                                Usuario nuevo = logica.CrearUsuarioCliente(txtNombre.Text, txtApellidos.Text, txtEmail.Text, txtTelefono.Text, cbxTipo.SelectedItem.ToString(), cbxDepartamento.SelectedItem.ToString());
                                if (nuevo == null)
                                {
                                    MessageBox.Show("Usuario ya existe", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                else
                                {
                                    MessageBox.Show("EL usuario " + nuevo.Nombre + " " + nuevo.Apellidos+" fue creado", "Usuario creado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    //AdminMenu menu = new AdminMenu(usuario);
                                    //menu.Show();
                                    this.Close();
                                }
                            }
                            else
                            {
                                Usuario nuevo = logica.CrearUsuario(txtNombre.Text, txtApellidos.Text, txtEmail.Text, txtTelefono.Text, cbxTipo.SelectedItem.ToString(), cbxDepartamento.SelectedItem.ToString(), txtUsuario.Text, txtContrasena.Text);
                                if (nuevo == null)
                                {
                                    MessageBox.Show("Usuario ya existe", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                else
                                {
                                    MessageBox.Show("EL usuario " + nuevo.Nombre + " " + nuevo.Apellidos+" fue creado", "Usuario creado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    //AdminMenu menu = new AdminMenu(usuario);
                                    //menu.Show();
                                    this.Close();
                                }
                            }
                       
                        }
                    }
                }
                else
                {
                    if (cbxTipo.SelectedItem.ToString().Equals("Cliente"))
                    {
                        Usuario nuevo = logica.CrearUsuarioCliente(txtNombre.Text, txtApellidos.Text, txtEmail.Text, txtTelefono.Text, cbxTipo.SelectedItem.ToString(), cbxDepartamento.SelectedItem.ToString());
                        if (nuevo == null)
                        {
                            MessageBox.Show("Usuario ya existe", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show("EL usuario " + nuevo.Nombre + " " + nuevo.Apellidos + " fue creado", "Usuario creado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            //AdminMenu menu = new AdminMenu(usuario);
                            //menu.Show();
                            this.Close();
                        }
                    }
                }
               
            }
        }

        private void mostrarCampos(object sender, EventArgs e)
        {
            if (cbxTipo.SelectedItem.ToString().Equals("Cliente"))
            {
                txtUsuario.Hide();
                label8.Hide();
                label9.Hide();
                label10.Hide();
                txtContrasena.Hide();
                txtContrasena2.Hide();
            }
            else
            {
                txtUsuario.Show();
                label8.Show();
                label9.Show();
                label10.Show();
                txtContrasena.Show();
                txtContrasena2.Show();
            }
        }

        private void rellenarUsuario(object sender, EventArgs e)
        {
            string[] usuario = txtEmail.Text.Split('@');
            txtUsuario.Text = usuario[0];
        }
    }
}
