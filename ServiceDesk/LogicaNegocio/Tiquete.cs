using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicaNegocio
{
    public class Tiquete
    {
        private int id;
        private string nombre;
        private string comentarios;
        private string fCreacion;
        private string fEstimada;
        private string fCierre;
        private string uSolicita;
        private int uAtiende;
        private int prioridad;
        private string estado;
        private int tipo;

        public Tiquete()
        {
            throw new System.NotImplementedException();
        }

        public Usuario Usuario
        {
            get => default(Usuario);
            set
            {
            }
        }

        public Tipo_Tiquete Tipo_Tiquete
        {
            get => default(Tipo_Tiquete);
            set
            {
            }
        }
    }
}