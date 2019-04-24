using AccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class UsuarioLogica
    {
        List<Usuario> usuarios = new List<Usuario>();

        public UsuarioLogica()
        {
            usuarios = BD.ObtenerUsuarios();
        }

        public void ActualizarLista()
        {
            usuarios = BD.ObtenerUsuarios();
        }

        public Usuario Login(string nombreusuario, string contrasena)
        {
            foreach (var usuario in usuarios)
            {
                if (usuario.NombreUsuario == nombreusuario)
                {
                    if (usuario.Contrasena == contrasena)
                    {
                        return usuario;
                    }
                    return null;
                }
            }
            return null;
        }

        public Usuario CrearUsuario(string nombre, string apellidos, string correo, string telefono, string tipo, string departamento, string usuario, string contrasena)
        {
            foreach (var u in usuarios)
            {
                if (!u.Tipo_usuario.Equals("Cliente"))
                {
                    if (u.NombreUsuario.Equals(usuario))
                    {
                        return null;
                    }
                }
                if (u.Correo.Equals(correo))
                {
                    return null;
                }
            }
            Usuario nuevo = new Usuario() {Nombre=nombre,Apellidos=apellidos,Correo=correo,Telefono=telefono,Tipo_usuario=tipo, Departamento=departamento, NombreUsuario=usuario, Contrasena=contrasena,Estado="A" };
            BD.CrearUsuario(nuevo);
            this.ActualizarLista();
            return nuevo;
        }

        public Usuario CrearUsuarioCliente(string nombre, string apellidos, string correo, string telefono, string tipo, string departamento)
        {
            string[] nombreusuario = correo.Split('@');
            foreach (var u in usuarios)
            {
                if (u.Correo.Equals(correo))
                {
                    return null;
                }
            }
            Usuario nuevo = new Usuario() { Nombre = nombre, Apellidos = apellidos, Correo = correo, Telefono = telefono, Tipo_usuario = tipo, Departamento = departamento,Estado="A",NombreUsuario=nombreusuario[0] };
            BD.CrearUsuario(nuevo);
            this.ActualizarLista();
            return nuevo;
        }

        public Usuario BuscarUsuario(string nombre, string apellidos)
        {
            foreach (var u in usuarios)
            {
                if(u.Nombre.Equals(nombre) && u.Apellidos.Equals(apellidos))
                {
                    return u;
                }
            }
            return null;
        }

        public Usuario BuscarUsuario(string email)
        {
            foreach (var u in usuarios)
            {
                if (u.Correo.Equals(email))
                {
                    return u;
                }
            }
            return null;
        }

        public Usuario BuscarUsuarioAdmin()
        {
            foreach (var u in usuarios)
            {
                if (u.Tipo_usuario.Equals("Administrador"))
                {
                    return u;
                }
            }
            return null;
        }

        public Usuario BuscarUsuarioPorNombreUsuario(string username)
        {
            foreach (var u in usuarios)
            {
                if (u.NombreUsuario.Equals(username))
                {
                    return u;
                }
            }
            return null;
        }

        public void EditarUsuario(string tel, string dep, string con, string est, string username)
        {
            BD.ModificarUsuario(tel, dep, con, est, username);
            usuarios = BD.ObtenerUsuarios();
        }

    }
}
