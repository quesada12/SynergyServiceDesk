using Dapper;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class BD
    {
        //STRING DE CONEXION PARA PC DE JOSUE
        static string connString = "Data Source=MSI\\JOSUE_SRV;Initial Catalog=SistemaTickets;Integrated Security=True;";

        //STRING DE CONEXION PARA PC DE XXXXXX
        //static string connString = "Data Source=NombreServidor;Initial Catalog=SistemaTickets;Integrated Security=True;";


        //METODOS DE CONEXION TABLA USUARIO

        public static List<Usuario> ObtenerUsuarios()
        {
            List<Usuario> usuarios;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                usuarios = conn.Query<Usuario>("select * from [SistemaTickets].[dbo].[usuario]").ToList();
            }
            return usuarios;
        }

        public static void CrearUsuario(Usuario usuario)
        {
            string sql = "insert into [SistemaTickets].[dbo].[usuario] ([nombre], [apellidos], [correo] , [telefono] , [tipo_usuario] , [departamento],[nombreusuario],[contrasena],[estado] ) VALUES (@nombre, @apellido, @correo,@telefono,@tipo_usuario,@departamento,@nombreusuario,@contrasena,@estado)";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                var rows = conn.Execute(sql, new
                {
                    usuario.Nombre,
                    usuario.Apellidos,
                    usuario.Correo,
                    usuario.Telefono,
                    usuario.Tipo_usuario,
                    usuario.Departamento,
                    usuario.NombreUsuario,
                    usuario.Contrasena,
                    usuario.Estado
                });
            }
        }

        public static void InactivarUsuario(Usuario usuario)
        {
            string sql = "update [SistemaTickets].[dbo].[usuario] set estado = @estado where nombreusuario = @nombreusuario";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                var rows = conn.Execute(sql, new
                {
                    nombreusuario = usuario.NombreUsuario,
                    estado = "I"
                });
            }
        }

        public static void ActivarUsuario(Usuario usuario)
        {
            string sql = "update [SistemaTickets].[dbo].[usuario] set estado = @estado where nombreusuario = @nombreusuario";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                var rows = conn.Execute(sql, new
                {
                    nombreusuario = usuario.NombreUsuario,
                    estado = "A"
                });
            }
        }

        //METODOS DE CONEXION TABLA DEPARTAMENTO 

        public static List<Departamento> ObtenerDepartamentos()
        {
            List<Departamento> departamentos;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                departamentos = conn.Query<Departamento>("select * from [SistemaTickets].[dbo].[departamento]").ToList();
            }
            return departamentos;
        }

        public static void CrearDepartamento(Departamento departamento)
        {
            string sql = "insert into [SistemaTickets].[dbo].[departamento] ([nombre_departamento], [descripcion] ) VALUES (@nombre_departamento, @descripcion)";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                var rows = conn.Execute(sql, new
                {
                    departamento.Nombre_departamento,
                    departamento.Descripcion
                });
            }
        }
    }
}
