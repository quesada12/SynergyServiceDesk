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
    public partial class CreaTickets : Form
    {
        List<TipoTicket> tipos = new List<TipoTicket>();
        List<PrioridadTicket> prioridades = new List<PrioridadTicket>();
        List<Usuario> usuarios = new List<Usuario>();
        Ticketslogica logica = new Ticketslogica();
        Usuario usuarioActual;

        public CreaTickets(Usuario usuario)
        {
            InitializeComponent();
            tipos = BD.ObtenerTipoTicket();
            prioridades = BD.ObtenerPrioridad();
            usuarios = BD.ObtenerUsuarios();
            usuarioActual = usuario;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void CreaTickets_Load(object sender, EventArgs e)
        {
            foreach (var t in tipos)
            {
                cmb_categoria.Items.Add(t.descripcion);
            }

            foreach(var p in prioridades)
            {
                cmb_prioridad.Items.Add(p.prioridad);
            }

            foreach (var u in usuarios)
            {
                if (u.Tipo_usuario.Equals("Cliente"))
                {
                    cmbSolicita.Items.Add(u.Correo);
                }
                if (u.Tipo_usuario.Equals("Tecnico"))
                {
                    cmb_tecnico.Items.Add(u.NombreUsuario);
                }
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_nombTicket.Text) || string.IsNullOrEmpty(txt_comentario.Text))
            {
                MessageBox.Show("Datos vacios", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_nombTicket.Text = "";
                txt_comentario.Text = "";
            }
            else
            {
                if (string.IsNullOrEmpty(cmbSolicita.SelectedIndex.ToString()) || string.IsNullOrEmpty(cmb_categoria.SelectedIndex.ToString()) || string.IsNullOrEmpty(cmb_prioridad.SelectedIndex.ToString()) || string.IsNullOrEmpty(cmb_tecnico.SelectedIndex.ToString()))
                {
                    MessageBox.Show("Datos vacios", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_nombTicket.Text = "";
                    txt_comentario.Text = "";
                }
                else
                {
                    Ticket t = logica.CrearTicket(txt_nombTicket.Text, txt_comentario.Text, cmbSolicita.SelectedItem.ToString(), cmb_tecnico.SelectedItem.ToString(), cmb_prioridad.SelectedItem.ToString(),"Pendiente", cmb_categoria.SelectedItem.ToString());
                    if (t != null)
                    {
                        MessageBox.Show("Ticket creado");
                        Dashboard dash = new Dashboard(usuarioActual);
                        dash.Show();
                        this.Close();
                    }
                }
            }

        }
    }
}
