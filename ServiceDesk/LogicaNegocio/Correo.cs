using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class Correo
    {

        private string to;
        private string bcc;
        private string subject;
        private string body;
      
        public string EnviarCorreo(string to, string subject, string body)
        {
            this.bcc = "controlticketscmc@gmail.com";
            this.to = to;
            this.subject = subject;
            this.body = body;

            //CREAR CORREO

            System.Net.Mail.MailMessage correo = new System.Net.Mail.MailMessage();

            //PARA
            correo.To.Add(to);

            //SUBJECT
            correo.Subject = subject;
            correo.SubjectEncoding = System.Text.Encoding.UTF8;

            //BCC
            correo.Bcc.Add(bcc);

            //BODY
            //body += "\n \n \n Departamento TIC \n Colegio de Médicos y Cirujanos de Costa Rica";
            correo.Body = body;
            correo.BodyEncoding = System.Text.Encoding.UTF8;

            //Config
            correo.IsBodyHtml = true;
            correo.From = new System.Net.Mail.MailAddress("controlticketscmc@gmail.com");

            //CREAR CLIENTE
            System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();
            cliente.Credentials = new System.Net.NetworkCredential("controlticketscmc@gmail.com", "tickets2019");
            cliente.Port = 587;
            cliente.EnableSsl = true;
            cliente.Host = "smtp.gmail.com";

            //ENVIO DEL CORREO

            try
            {
                cliente.Send(correo);
                return "Confirmación enviada por correo electrónico";
            }
            catch (Exception)
            {

                return "Error al enviar confirmación por correo electrónico";
            }

        }
    }


        
}
