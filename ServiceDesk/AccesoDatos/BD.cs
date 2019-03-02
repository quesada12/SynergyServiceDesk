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
        //static string connString = "Data Source=MSI\\JOSUE_SRV;Initial Catalog=SistemaTickets;Integrated Security=True;";

        //STRING DE CONEXION PARA PC DE XXXXXX
        static string connString = "Data Source=ADRIAN\\MSSQLSRVER;Initial Catalog=SistemaTickets;Integrated Security=True;";


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
            string sql = "insert into [SistemaTickets].[dbo].[usuario] ([nombre], [apellidos], [correo] , [telefono] , [tipo_usuario] , [departamento],[nombreusuario],[contrasena],[estado] ) VALUES (@nombre, @apellidos, @correo,@telefono,@tipo_usuario,@departamento,@nombreusuario,@contrasena,@estado)";
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
            string sql = "update [SistemaTickets].[dbo].[usuario] set estado = @estado where nombre = @nombre and apellidos=@apellidos";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                var rows = conn.Execute(sql, new
                {
                    nombre=usuario.Nombre,
                    apellidos=usuario.Apellidos,
                    estado = "I"
                });
            }
        }

        public static void ActivarUsuario(Usuario usuario)
        {
            string sql = "update [SistemaTickets].[dbo].[usuario] set estado = @estado where nombre = @nombre and apellidos=@apellidos";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                var rows = conn.Execute(sql, new
                {
                    nombre = usuario.Nombre,
                    apellidos = usuario.Apellidos,
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

        //METODOS DE CONEXION TABLA TICKETS

        // INSERT A TABLA TICKET 
        public static void CrearTicket(Ticket ticket)
        {
            string sql = "insert into [SistemaTickets].[dbo].[ticket] ([nombre_ticket], [comentarios], [fecha_creacion], [fecha_estimada], [fecha_cierre], [usuario_solicita], [usuario_atiende],[prioridad],[estado],[tipo_ticket] ) VALUES (@nombre_ticket, @comentarios, @fecha_creacion, @fecha_estimada, @fecha_cierre, @usuario_solicita, @usuario_atiende, @prioridad, @estado, @tipo_ticket)";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                var rows = conn.Execute(sql, new
                {
                    ticket.nombre_ticket,
                    ticket.comentarios,
                    ticket.fecha_creacion,
                    ticket.fecha_estimada,
                    ticket.fecha_cierre,
                    ticket.usuario_solicita,
                    ticket.usuario_atiende,
                    ticket.prioridad,
                    ticket.estado,
                    ticket.tipo_ticket
                });
            }
        }

        // SELECT  DE TICKETS

        public static List<Ticket> ObtenerTickets()
        {
            List<Ticket> ticket;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                ticket = conn.Query<Ticket>("select * from [SistemaTickets].[dbo].[ticket]").ToList();
            }
            return ticket;
        }

        // SELECT PARA LA PRIORIDAD DE TICKETS

        public static List<PrioridadTicket> ObtenerPrioridad()
        {
            List<PrioridadTicket> prioridad;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                prioridad = conn.Query<PrioridadTicket>("select * from [SistemaTickets].[dbo].[prioridad]").ToList();
            }
            return prioridad;
        }

        // SELECT PARA EL ESTADO DE TICKETS

        public static List<EstadoTicket> ObtenereSTADO()
        {
            List<EstadoTicket> estado;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                estado = conn.Query<EstadoTicket>("select * from [SistemaTickets].[dbo].[estado]").ToList();
            }
            return estado;
        }

        // SELECT PARA LA CATEGORIA DE TICKETS

        public static List<CategoriaTicket> ObtenerCategoria()
        {
            List<CategoriaTicket> categoria;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                categoria = conn.Query<CategoriaTicket>("select * from [SistemaTickets].[dbo].[tipo_ticket]").ToList();
            }
            return categoria;
        }

    }
}
