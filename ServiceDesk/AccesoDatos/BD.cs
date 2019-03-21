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

        //STRING DE CONEXION PARA PC DE Adrian
        //static string connString = "Data Source=ADRIAN\\MSSQLSRVER;Initial Catalog=SistemaTickets;Integrated Security=True;";
        //STRING DE CONEXION PARA PC DE Ricardo
        //static string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=SistemaTickets;Integrated Security=True;";

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

        public static void ModificarUsuario(string tel, string dep, string con, string est, string username)
        {
            string sql = "update [SistemaTickets].[dbo].[usuario] set telefono = @telefono , departamento = @dpt, contrasena = @contrasena, estado=@estado where nombreusuario = @nombreusuario";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                var rows = conn.Execute(sql, new
                {
                    telefono = tel,
                    dpt = dep,
                    contrasena = con,
                    estado = est,
                    nombreusuario = username
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

        //METODOS DE CONEXION TABLA COMENTARIO

        public static void CrearComentario(Comentario comentario)
        {
            string sql = "insert into [SistemaTickets].[dbo].[comentario] ([id_ticket], [usuario_tecnico], [comentario] ) VALUES (@id_ticket, @usuario_tecnico, @comentario)";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                var rows = conn.Execute(sql, new
                {
                    comentario.id_Ticket,
                    comentario.usuario_tecnico,
                    comentario.comentario
                });
            }
        }
        
        
        //METODOS DE CONEXION TABLA TICKETS

        // INSERT A TABLA TICKET 
        public static void CrearTicket(Ticket ticket)
        {
            string sql = "insert into [SistemaTickets].[dbo].[ticket] ([nombre_ticket], [comentarios], [fecha_creacion], [fecha_estimada], [fecha_cierre], [correo_solicita], [usuario_atiende],[prioridad],[estado],[tipo_ticket] ) VALUES (@nombre_ticket, @comentarios, @fecha_creacion, @fecha_estimada, @fecha_cierre, @correo_solicita, @usuario_atiende, @prioridad, @estado, @tipo_ticket)";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                var rows = conn.Execute(sql, new
                {
                    ticket.nombre_ticket,
                    ticket.comentarios,
                    ticket.fecha_creacion,
                    ticket.fecha_estimada,
                    ticket.fecha_cierre,
                    ticket.correo_solicita,
                    ticket.usuario_atiende,
                    ticket.prioridad,
                    ticket.estado,
                    ticket.tipo_ticket
                });
            }
        }

        public static void ModificarTicket(int id_ticket, string estado)
        {
            string sql = "update [SistemaTickets].[dbo].[ticket] set estado = @estado where id_ticket = @id_ticket";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                var rows = conn.Execute(sql, new
                {
                    id_ticket = id_ticket,
                    estado = estado
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

        public static List<TipoTicket> ObtenerTipoTicket()
        {
            List<TipoTicket> tipos;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                tipos = conn.Query<TipoTicket>("select * from [SistemaTickets].[dbo].[tipo_ticket]").ToList();
            }
            return tipos;
        }

        

    }
}
