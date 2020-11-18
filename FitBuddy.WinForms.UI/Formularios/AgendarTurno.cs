using FitBuddy.Business.Facade;
using FitBuddy.WinForms.UI.Security;
using MetroFramework.Forms;
using System;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace FitBuddy.WinForms.UI.Formularios
{
    public partial class AgendarTurno : MetroForm
    {
        private readonly IFormManager _formManager;
        private readonly IAgendarTurnoBusinessLogic _agendarTurnoBusinessLogic;

        public AgendarTurno(IFormManager formManager, IAgendarTurnoBusinessLogic agendarTurnoBusinessLogic)
        {
            InitializeComponent();
            lblWelcome.Text = $"Usuario {IdentityManager.UsuarioActual.Username}";
            _formManager = formManager;
            _agendarTurnoBusinessLogic = agendarTurnoBusinessLogic;
        }

        private void OnAgendarTurnoLoad(object sender, EventArgs e)
        {
            cmbMedico.DataSource = _agendarTurnoBusinessLogic.ObtenerMédicos();
            cmbMedico.DisplayMember = "Nombre";
            cmbMedico.ValueMember = "Email";

            cmbFranjaHoraria.Items.Add("9:00");
            cmbFranjaHoraria.Items.Add("10:00");
            cmbFranjaHoraria.Items.Add("11:00");
            cmbFranjaHoraria.Items.Add("12:00");
            cmbFranjaHoraria.Items.Add("13:00");
            cmbFranjaHoraria.Items.Add("14:00");
        }

        private void OnBtnEnviarClick(object sender, EventArgs e)
        {
            var host = ConfigurationManager.AppSettings["SmtpClientHost"];
            var port = ConfigurationManager.AppSettings["SmtpClientPort"];
            var email = ConfigurationManager.AppSettings["NetworkCredentialsEmail"];
            var password = ConfigurationManager.AppSettings["NetworkCredentialsPassword"];

            var configData = new[] { host, port, email, password };
            if (configData.Any(string.IsNullOrWhiteSpace))
            {
                MessageBox.Show("Las credenciales del servidor SMTP han sido corrompidas. Contacte al servicio de soporte de FitBuddy.");
                return;
            }

            var smtpClient = new SmtpClient(host, int.Parse(port))
            {
                UseDefaultCredentials = false,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Credentials = new NetworkCredential(email, password)
            };

            var emailMedico = cmbMedico.SelectedValue.ToString();
            var nombreMedico = cmbMedico.Text;

            // add from,to mailaddresses
            var from = new MailAddress("fitbuddyturnos@gmail.com", "FitBuddy");
            var to = new MailAddress(emailMedico, nombreMedico);
            var usuario = IdentityManager.UsuarioActual.Name;
            var body = $"<b>Estimado, el paciente {usuario} solicita un turno para el día {dtpFecha.Value:dd-MM-yyyy} a las {cmbFranjaHoraria.Text}.</b>.";
            var message = new MailMessage(from, to)
            {
                Subject = "Test message",
                SubjectEncoding = Encoding.UTF8,
                Body = body,
                BodyEncoding = Encoding.UTF8,
                IsBodyHtml = true
            };

            message.Headers.Add("Content-class", "urn:content-classes:calendarmessage");

            var replyTo = new MailAddress("reply@example.com");
            message.ReplyToList.Add(replyTo);

            // Archivo ICS
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

            var contentType = new System.Net.Mime.ContentType("text/calendar");
            contentType.Parameters.Add("method", "REQUEST");
            contentType.Parameters.Add("name", "Meeting.ics");
            var avCal = AlternateView.CreateAlternateViewFromString(sb.ToString(), contentType);
            message.AlternateViews.Add(avCal);

            smtpClient.Send(message);

            MessageBox.Show("Turno cargado con éxito, un administrador se pondrá en contacto para coordinar tu cita.");
            BorrarCampos();
        }

        private void BorrarCampos()
        {
            cmbFranjaHoraria.Text = string.Empty;
            cmbMedico.Text = string.Empty;
        }

        private void OnBtnAtrasClick(object sender, EventArgs e)
        {
            _formManager.Close(this);
        }
    }
}
