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
    public partial class EnviarCorreo : Form
    {
        Ticket ticket;
        Usuario usuarioActual;

        public EnviarCorreo(Ticket ticket, Usuario usuarioActual)
        {
            InitializeComponent();
            txtTo.Text = ticket.correo_solicita;
            this.ticket = ticket;
            this.usuarioActual = usuarioActual;
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ModificarTickets modificar = new ModificarTickets(ticket, usuarioActual);
            modificar.Show();
            this.Close();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSubject.Text) || string.IsNullOrEmpty(txtBody.Text))
            {
                MessageBox.Show("No pueden haber campos vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Correo enviar = new Correo();
                string resultado = enviar.EnviarCorreo(txtTo.Text, txtSubject.Text, txtBody.Text);
                MessageBox.Show(resultado, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ModificarTickets modificar = new ModificarTickets(ticket, usuarioActual);
                modificar.Show();
                this.Close();
            }
            
        }
    }
}
