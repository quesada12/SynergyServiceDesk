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

namespace Interfaz
{
    public partial class CreaTickets : Form
    {
        List<CategoriaTicket> categoria = new List<CategoriaTicket>();
        List<EstadoTicket> estado = new List<EstadoTicket>();
        List<PrioridadTicket> prioridad = new List<PrioridadTicket>();

        public CreaTickets()
        {
            InitializeComponent();
            categoria = BD.ObtenerCategoria();
            estado = BD.ObtenereSTADO();
            prioridad = BD.ObtenerPrioridad();
            CargaCategoria();
            CargaEstado();
            CargaPrioridad();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargaCategoria()
        {
            cmb_categoria.DataSource = categoria;
            cmb_categoria.ValueMember = nameof(CategoriaTicket.id_tipoticket);
            cmb_categoria.DisplayMember = nameof(CategoriaTicket.tipo);
            //foreach (var e in estado)
            //{
            //    cmb_estado.Items.Add(e.estado);
            //}
        }

        private void CargaEstado()
        {
            cmb_estado.DataSource = estado;
            cmb_estado.ValueMember = nameof(EstadoTicket.id_estado);
            cmb_estado.DisplayMember = nameof(EstadoTicket.estado);
        }

        private void CargaPrioridad()
        {
            cmb_prioridad.DataSource = prioridad;
            cmb_prioridad.ValueMember = nameof(PrioridadTicket.id_prioridad);
            cmb_prioridad.DisplayMember = nameof(PrioridadTicket.prioridad);
        }

        private void cmb_categoria_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cmb_estado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbPrioridad_SelectedIndexChanged(object sender, EventArgs e)
        {
            string prioridad = cmb_prioridad.SelectedValue.ToString();
        }
    }
}
