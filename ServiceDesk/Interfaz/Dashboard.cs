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

namespace Interfaz
{
    public partial class Dashboard : DevExpress.XtraEditors.XtraForm
    {
        Usuario usuario;
        public Dashboard()
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            label8.Text = usuario.NombreUsuario;
        }

        private void tileBar_SelectedItemChanged(object sender, TileItemEventArgs e)
        {
            navigationFrame.SelectedPageIndex = tileBarGroupTables.Items.IndexOf(e.Item);
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            CrearUsuario nuevo = new CrearUsuario(usuario);
            nuevo.Show();
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            ActivarUsuario activar = new ActivarUsuario(usuario);
            activar.Show();
        }

        private void btnInactivar_Click(object sender, EventArgs e)
        {
            InactivarUsuario inactivar = new InactivarUsuario(usuario);
            inactivar.Show();
        }

        private void btnCreaTicket_Click(object sender, EventArgs e)
        {
            CreaTickets crear = new CreaTickets();
            crear.Show();
        }

        private void btnCreaDpt_Click(object sender, EventArgs e)
        {
            CrearDepartamento dpt = new CrearDepartamento(usuario);
            dpt.Show();
        }
    }
}