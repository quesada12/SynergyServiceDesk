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
    public partial class CrearDepartamento : Form
    {
        Usuario usuario;
        
        public CrearDepartamento(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtDescripcion.Text))
            {
                MessageBox.Show("Datos erroneos", "Departamento", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DepartamentoLogica logica = new DepartamentoLogica();
                Departamento nuevo = logica.CrearDepartamento(txtNombre.Text,txtDescripcion.Text);
                if (nuevo == null)
                {
                    MessageBox.Show("Departamento ya existe", "Departamento", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNombre.Text = "";
                    txtDescripcion.Text = "";
                }
                else
                {
                    MessageBox.Show("Departamento " + nuevo.Nombre_departamento + " fue creado", "Departamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //AdminMenu menu = new AdminMenu(usuario);
                    //menu.Show();
                    this.Close();
                }
            }
        }
    }
}
