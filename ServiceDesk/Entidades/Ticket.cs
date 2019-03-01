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
        public int usuario_solicita { get; set; }
        public string usuario_atiende { get; set; }
        public int prioridad { get; set; }
        public int estado { get; set; }
        public int tipo_ticket { get; set; }

    }
}
