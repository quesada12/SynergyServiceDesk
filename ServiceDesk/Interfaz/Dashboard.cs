using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Interfaz.Administración_Usuarios;
using LogicaNegocio;
using Interfaz.Administración_Tickets;

namespace Interfaz
{
    public partial class Dashboard : DevExpress.XtraEditors.XtraForm
    {
        Usuario usuarioActual;
        Ticketslogica logicaTicket = new Ticketslogica();

        //HILO PARA ACTUALIZAR GRID Y GRÁFICOS
        private void IniciarTimer()
        {
            timer1.Interval = 5000;
            timer1.Tick += new EventHandler(ActualizarComponentes);
            timer1.Enabled = true;
            
        }

        private void ActualizarComponentes(object sender, EventArgs e)
        {
            // Cargar los tickets en el grid
            listaTicketsActivosTableAdapter1.Fill(ticketsActivos1.ListaTicketsActivos);
            // TODO: esta línea de código carga datos en la tabla 'ticketsPorMes._TicketsPorMes' Puede moverla o quitarla según sea necesario.
            this.ticketsPorMesTableAdapter.Fill(this.ticketsPorMes._TicketsPorMes);
            // TODO: esta línea de código carga datos en la tabla 'ticketsXTecnico.TicketsPorTecnico' Puede moverla o quitarla según sea necesario.
            this.ticketsPorTecnicoTableAdapter.Fill(this.ticketsXTecnico.TicketsPorTecnico);
        }


        public Dashboard(Usuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;

            // Cargar los tickets en el grid
            listaTicketsActivosTableAdapter1.Fill(ticketsActivos1.ListaTicketsActivos);

            this.IniciarTimer();
        }



        private void tileBar_SelectedItemChanged(object sender, TileItemEventArgs e)
        {
            navigationFrame.SelectedPageIndex = tileBarGroupTables.Items.IndexOf(e.Item);
        }

        //CREAR USUARIO
        private void btnUsuario_Click(object sender, EventArgs e)
        {
            CrearUsuario nuevo = new CrearUsuario(usuarioActual);
            nuevo.Show();
        }

      
        //CREAR TICKET
        private void btnCreaTicket_Click(object sender, EventArgs e)
        {
            CreaTickets crear = new CreaTickets(usuarioActual);
            crear.Show();
            
        }

        //CREAR DEPARTAMENTO
        private void btnCreaDpt_Click(object sender, EventArgs e)
        {
            CrearDepartamento dpt = new CrearDepartamento(usuarioActual);
            dpt.Show();
        }

        //MODIFICAR USUARIO
        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarUsuario modificar = new ModificarUsuario(usuarioActual);
            modificar.Show();
        }

        private void editarTicket(object sender, EventArgs e)
        {
            string nombre = listaTickets.GetRowCellValue(listaTickets.FocusedRowHandle, "Nombre").ToString();
            string creacion = listaTickets.GetRowCellValue(listaTickets.FocusedRowHandle, "Creacion").ToString();
            string tipo = listaTickets.GetRowCellValue(listaTickets.FocusedRowHandle, "Tipo").ToString();
            if (nombre.Equals(""))
            {
                MessageBox.Show("Favor seleccione un ticket", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (logicaTicket.BuscarTicket(nombre,creacion,tipo) != null)
                {
                    Ticket edicion = logicaTicket.BuscarTicket(nombre, creacion, tipo);
                    ModificarTickets editar = new ModificarTickets(edicion, usuarioActual);
                    editar.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Algo raro");
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ticketsPorMes._TicketsPorMes' Puede moverla o quitarla según sea necesario.
            this.ticketsPorMesTableAdapter.Fill(this.ticketsPorMes._TicketsPorMes);
            // TODO: esta línea de código carga datos en la tabla 'ticketsXTecnico.TicketsPorTecnico' Puede moverla o quitarla según sea necesario.
            this.ticketsPorTecnicoTableAdapter.Fill(this.ticketsXTecnico.TicketsPorTecnico);

        }
    }
}