using AccesoDatos;
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

namespace Interfaz.Administración_Tickets
{
    public partial class CrearComentario : Form
    {
        Ticket ticket;
        Usuario usuarioActual;

        public CrearComentario(Ticket ticket, Usuario usuarioActual)
        {
            InitializeComponent();
            this.ticket = ticket;
            this.usuarioActual = usuarioActual;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Comentario comentario = new Comentario() {id_Ticket=ticket.id_ticket,comentario=txtComentario.Text,usuario_tecnico=usuarioActual.NombreUsuario };
            BD.CrearComentario(comentario);
            MessageBox.Show("Comentario agregado");
            ModificarTickets modificar = new ModificarTickets(ticket, usuarioActual);
            modificar.Show();
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ModificarTickets modificar = new ModificarTickets(ticket, usuarioActual);
            modificar.Show();
            this.Close();
        }
    }
}
