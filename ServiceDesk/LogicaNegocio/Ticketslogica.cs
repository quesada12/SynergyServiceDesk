using AccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class Ticketslogica
    {
        List<Ticket> tickets = new List<Ticket>();
        
        
        public Ticketslogica()
        {
            tickets = BD.ObtenerTickets();
        }

        public Ticket CrearTicket(string nombre, string comentarios, string usuario, string tecnico, string prioridad, string estado, string tipo)
        {
            string fecha = DateTime.Now.ToString("yyyyMMdd", System.Globalization.CultureInfo.GetCultureInfo("en-US"));
            Ticket nuevo = new Ticket() {fecha_creacion=fecha,nombre_ticket=nombre, comentarios=comentarios, correo_solicita=usuario, usuario_atiende=tecnico,prioridad=prioridad, estado=estado, tipo_ticket=tipo };
            BD.CrearTicket(nuevo);
            return nuevo;
        }

        public Ticket BuscarTicket(string nombre, string creacion, string tipo)
        {
            tickets = BD.ObtenerTickets();
            foreach (var t in tickets)
            {
                if (t.nombre_ticket.Equals(nombre) && t.fecha_creacion.Equals(creacion) && t.tipo_ticket.Equals(tipo))
                {
                    return t;
                }
            }
            return null;
        }

        public void EditarTicket(int id, string estado)
        {
            BD.ModificarTicket(id, estado);
            tickets = BD.ObtenerTickets();
        }
    }
}
