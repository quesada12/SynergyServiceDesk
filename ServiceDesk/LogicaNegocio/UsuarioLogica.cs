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

        public int Login(string nombreusuario, string contrasena)
        {
            foreach (var usuario in usuarios)
            {
                if (usuario.NombreUsuario == nombreusuario)
                {
                    if (usuario.Contrasena == contrasena)
                    {
                        if (usuario.Estado == "A")
                        {
                            return 0;
                        }
                        return 1;
                    }
                    return 2;
                }
            }
            return 3;
        }

    }
}
