using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicaNegocio
{
    public class Usuario
    {
        private int id;
        private string nombre;
        private string apellidos;
        private string correo;
        private string telefono;
        private int tipo;
        private int departamento;
        private string nombreUsuario;
        protected string contrasena;
        private int estado;

        public Usuario()
        {
            throw new System.NotImplementedException();
        }

        public Departamento Departamento
        {
            get => default(Departamento);
            set
            {
            }
        }

        public Tipo_Usuario Tipo_Usuario
        {
            get => default(Tipo_Usuario);
            set
            {
            }
        }
    }
}