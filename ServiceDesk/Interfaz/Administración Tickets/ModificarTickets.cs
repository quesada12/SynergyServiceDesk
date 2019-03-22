﻿using AccesoDatos;
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

namespace Interfaz.Administración_Tickets
{
    public partial class ModificarTickets : Form
    {
        Ticket ticket;
        Usuario usuarioActual;
        Ticketslogica logica = new Ticketslogica();
        List<Usuario> usuarios = new List<Usuario>();

        public ModificarTickets(Ticket ticket, Usuario usuarioActual)
        {
            InitializeComponent();
            this.ticket = ticket;
            this.usuarioActual = usuarioActual;
            // This line of code is generated by Data Source Configuration Wizard
            listaComentariosTableAdapter1.Fill(conexionComentarios1.ListaComentarios);
        }


        private void cargaUsuarios()
        {
            usuarios = BD.ObtenerUsuarios();
            foreach (var u in usuarios)
            {
                if (u.Tipo_usuario.Equals("Tecnico") && u.Estado.Equals("A") && !u.NombreUsuario.Equals(ticket.usuario_atiende))
                {
                    cbxTecnico.Items.Add(u.NombreUsuario.ToString());
                }
            }
        }

        private void ModificarTickets_Load(object sender, EventArgs e)
        {

            this.cargaUsuarios();

            cbxEstado.Items.Add("Pendiente");
            cbxEstado.Items.Add("Proceso");
            cbxEstado.Items.Add("Completado");

            txt_nombTicket.Text = ticket.nombre_ticket;
            txtUsuarioSolicita.Text = ticket.correo_solicita;
        
            txtTipo.Text = ticket.tipo_ticket;
            txtPrioridad.Text = ticket.prioridad;
            txt_comentario.Text = ticket.comentarios;
            cbxEstado.Text = ticket.estado;
            cbxTecnico.Text = ticket.usuario_atiende;
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard(usuarioActual);
            dash.Show();
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (cbxEstado.SelectedItem == null)
            {
                logica.EditarTicket(ticket.id_ticket, cbxEstado.Text, cbxTecnico.SelectedItem.ToString());
                MessageBox.Show("Ticket Actualizado");
            }
            else
            {
                if (cbxTecnico.SelectedItem == null)
                {
                    logica.EditarTicket(ticket.id_ticket, cbxEstado.SelectedItem.ToString(), cbxTecnico.Text);
                    MessageBox.Show("Ticket Actualizado");
                }
                else
                {
                    logica.EditarTicket(ticket.id_ticket, cbxEstado.SelectedItem.ToString(), cbxTecnico.SelectedItem.ToString());
                    MessageBox.Show("Ticket Actualizado");
                }
            }




            this.cargaUsuarios();
            Dashboard dash = new Dashboard(usuarioActual);
            dash.Show();
            this.Close();
        }

        private void filtrar(object sender, EventArgs e)
        {
            for (int i = 0; i < listaComentarios.RowCount; i++)
            {
                if (!listaComentarios.GetRowCellValue(i, "Ticket ID").ToString().Equals(ticket.id_ticket.ToString()))
                {
                    listaComentarios.DeleteRow(i);
                    i -= 1;
                }
            }
        }

        private void btnAgregarComentario_Click(object sender, EventArgs e)
        {
            CrearComentario crear = new CrearComentario(ticket,usuarioActual);
            crear.Show();
            this.Close();
        }
    }
}
