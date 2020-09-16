using System;
using System.Net;
using System.Net.Mail;

namespace PruebaMail
{
    class Program
    {
        static void Main(string[] args)
        {
            var fromAddress = new MailAddress("patricia.hernandez.miraballes@gmail.com", "Patricia Hernandez"); //casilla desde donde envio
            var toAddress = new MailAddress("dmiquele@gmail.com", "To Name"); //email destino
            const string fromPassword = "Patopepy2401"; //clave del propietario
            const string subject = "Prueba de mail"; //asunto - envio de Listado de proveedor
            const string body = "este sería el cuerpo del mail divino"; //cuerpo - 

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                UseDefaultCredentials = false,
                //las siguientes 3 propiedades tienen que estar en ese orden
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword),
                EnableSsl = true
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
        }
    }
}
