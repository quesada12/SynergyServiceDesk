﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        public int Id_usuario { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Tipo_usuario { get; set; }
        public string Departamento { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }
        public string Estado { get; set; }
    }
}
