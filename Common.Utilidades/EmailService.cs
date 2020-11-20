using System;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace Common.Utilidades
{
    public interface IEmailService
    {
        MailMessage CrearMensaje(string fromAddress, string fromName, string toAddress, string toName, string replyTo, string asuntoMensaje, string cuerpoMensaje, bool conFormatoHtml);
        void Enviar(string smtpClientHost, int smtpClientPort, string networkCredentialsEmail, string networkCredentialsPassword, MailMessage mensaje);
    }

    public class EmailService : IEmailService
    {
        public void Enviar(string smtpClientHost, int smtpClientPort, string networkCredentialsEmail, string networkCredentialsPassword, MailMessage mensaje)
        {
            try
            {
                using (var smtpClient = new SmtpClient(smtpClientHost, smtpClientPort)
                {
                    UseDefaultCredentials = false,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    Credentials = new NetworkCredential(networkCredentialsEmail, networkCredentialsPassword)
                })
                {
                    smtpClient.Send(mensaje);
                }
            }
            catch (Exception e)
            {
                throw new Exception($"Error al enviar el correo electrónico. Detalles de la excepción:\n{e.Message}");
            }
        }

        public MailMessage CrearMensaje(string fromAddress, string fromName, string toAddress, string toName, string replyTo, string asuntoMensaje, string cuerpoMensaje, bool conFormatoHtml)
        {
            if (string.IsNullOrWhiteSpace(cuerpoMensaje))
            {
                throw new ArgumentNullException("El mensaje del correo electrónico no tiene contenido.");
            }

            MailAddress from;
            MailAddress to;

            try
            {
                from = new MailAddress(fromAddress, fromName);
                to = new MailAddress(toAddress, toName);
            }
            catch (Exception e)
            {
                var sbLog = new StringBuilder();
                sbLog.Append("Error al intentar crear direcciones de correo para ");
                sbLog.Append($"el remitente '{fromAddress}' y para ");
                sbLog.Append($"el médico '{toAddress}'. ");
                sbLog.AppendLine("Detalles de la excepción:");
                sbLog.Append(e.Message);

                throw new ArgumentException(sbLog.ToString());
            }

            var message = new MailMessage(from, to)
            {
                Subject = asuntoMensaje,
                SubjectEncoding = Encoding.UTF8,
                Body = cuerpoMensaje,
                BodyEncoding = Encoding.UTF8,
                IsBodyHtml = conFormatoHtml
            };

            message.Headers.Add("Content-class", "urn:content-classes:calendarmessage");

            if (!string.IsNullOrWhiteSpace(replyTo))
                message.ReplyToList.Add(replyTo);

            var contentType = new System.Net.Mime.ContentType("text/calendar");
            contentType.Parameters.Add("method", "REQUEST");
            contentType.Parameters.Add("name", "Meeting.ics");
            var contenidoArchivoIcs = CrearContenidoArchivoIcs(message);
            var avCal = AlternateView.CreateAlternateViewFromString(contenidoArchivoIcs, contentType);
            message.AlternateViews.Add(avCal);
            return message;
        }

        private string CrearContenidoArchivoIcs(MailMessage message)
        {
            var sb = new StringBuilder();
            sb.AppendLine("BEGIN:VCALENDAR");
            sb.AppendLine("PRODID:-//Schedule a Meeting");
            sb.AppendLine("VERSION:2.0");
            sb.AppendLine("METHOD:REQUEST");
            sb.AppendLine("BEGIN:VEVENT");
            sb.AppendLine(string.Format("DTSTART:{0:yyyyMMddTHHmmssZ}", DateTime.Now.AddMinutes(+330)));
            sb.AppendLine(string.Format("DTSTAMP:{0:yyyyMMddTHHmmssZ}", DateTime.UtcNow));
            sb.AppendLine(string.Format("DTEND:{0:yyyyMMddTHHmmssZ}", DateTime.Now.AddMinutes(+660)));
            sb.AppendLine("LOCATION: Consultorio"); // TODO
            sb.AppendLine(string.Format("UID:{0}", Guid.NewGuid()));
            sb.AppendLine(string.Format("DESCRIPTION:{0}", message.Body));
            sb.AppendLine(string.Format("X-ALT-DESC;FMTTYPE=text/html:{0}", message.Body));
            sb.AppendLine(string.Format("SUMMARY:{0}", message.Subject));
            sb.AppendLine(string.Format("ORGANIZER:MAILTO:{0}", message.From.Address));

            sb.AppendLine(string.Format("ATTENDEE;CN=\"{0}\";RSVP=TRUE:mailto:{1}", message.To[0].DisplayName, message.To[0].Address));

            sb.AppendLine("BEGIN:VALARM");
            sb.AppendLine("TRIGGER:-PT15M");
            sb.AppendLine("ACTION:DISPLAY");
            sb.AppendLine("DESCRIPTION:Reminder");
            sb.AppendLine("END:VALARM");
            sb.AppendLine("END:VEVENT");
            sb.AppendLine("END:VCALENDAR");

            return sb.ToString();
        }
    }
}
