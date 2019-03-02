using AccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class CategoriaLogica
    {
        List<CategoriaTicket> categoria = new List<CategoriaTicket>();

        public CategoriaLogica()
        {
            categoria = BD.ObtenerCategoria();
        }
    }
}
