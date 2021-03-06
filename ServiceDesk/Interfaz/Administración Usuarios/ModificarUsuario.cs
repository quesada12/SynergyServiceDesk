﻿using Entidades;
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
    public partial class ModificarUsuario : Form
    {
        Usuario usuarioActual;
        UsuarioLogica logica = new UsuarioLogica();

        public ModificarUsuario(Usuario usuario)
        {
            InitializeComponent();

            usuarioActual = usuario;
            // This line of code is generated by Data Source Configuration Wizard
            listaUsuariosTableAdapter1.Fill(conexionUsuarios1.ListaUsuarios);
        }

        private void verUsuario(object sender, EventArgs e)
        {
            string email = listaUsuarios.GetRowCellValue(listaUsuarios.FocusedRowHandle, "Email").ToString();
            if (email.Equals(""))
            {
                MessageBox.Show("Favor seleccione un usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (logica.BuscarUsuario(email) != null)
                {
                    Usuario edicion = logica.BuscarUsuario(email);
                    EditarUsuario editar = new EditarUsuario(usuarioActual, edicion);
                    editar.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Algo raro");
                }
            }
        }
    }
}
