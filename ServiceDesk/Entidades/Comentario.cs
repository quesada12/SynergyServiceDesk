using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Comentario
    {
        public int id_Ticket { get; set; }
        public string usuario_tecnico { get; set; }
        public string comentario { get; set; }

    }
}
