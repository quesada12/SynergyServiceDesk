using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ticket
    {

        public int id_ticket { get; set; }
        public string nombre_ticket { get; set; }
        public string comentarios { get; set; }
        public string fecha_creacion { get; set; }
        public string fecha_estimada { get; set; }
        public string fecha_cierre { get; set; }
        public string correo_solicita { get; set; }
        public string usuario_atiende { get; set; }
        public string prioridad { get; set; }
        public string estado { get; set; }
        public string tipo_ticket { get; set; }

    }
}
