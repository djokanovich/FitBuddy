using FitBuddy.Business.Facade;
using FitBuddy.WinForms.UI.Security;
using MetroFramework.Forms;
using System;
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
            var smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.UseDefaultCredentials = false;
            smtpClient.EnableSsl = true;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.Credentials = new NetworkCredential("fitbuddyturnos@gmail.com", "");

            var emailMedico = cmbMedico.SelectedValue.ToString();
            var nombreMedico = cmbMedico.Text;

            // add from,to mailaddresses
            var from = new MailAddress("test@example.com", "TestFromName");
            var to = new MailAddress(emailMedico, nombreMedico);
            var message = new MailMessage(from, to);

            // add ReplyTo
            var replyTo = new MailAddress("reply@example.com");
            message.ReplyToList.Add(replyTo);

            // set subject and encoding
            message.Subject = "Test message";
            message.SubjectEncoding = Encoding.UTF8;

            var usuario = IdentityManager.UsuarioActual.Name;
            // set body-message and encoding
            message.Body = $"<b>Estimado, el paciente {usuario} solicita un turno para el día {dtpFecha.Value:dd-MM-yyyy} a las {cmbFranjaHoraria.Text}.</b>.";
            message.BodyEncoding = Encoding.UTF8;
            // text or html
            message.IsBodyHtml = true;

            // Now Contruct the ICS file using string builder
            var str = new StringBuilder();
            str.AppendLine("BEGIN:VCALENDAR");
            str.AppendLine("PRODID:-//Schedule a Meeting");
            str.AppendLine("VERSION:2.0");
            str.AppendLine("METHOD:REQUEST");
            str.AppendLine("BEGIN:VEVENT");
            str.AppendLine(string.Format("DTSTART:{0:yyyyMMddTHHmmssZ}", DateTime.Now.AddMinutes(+330)));
            str.AppendLine(string.Format("DTSTAMP:{0:yyyyMMddTHHmmssZ}", DateTime.UtcNow));
            str.AppendLine(string.Format("DTEND:{0:yyyyMMddTHHmmssZ}", DateTime.Now.AddMinutes(+660)));
            str.AppendLine("LOCATION: Consultorio"); // TODO
            str.AppendLine(string.Format("UID:{0}", Guid.NewGuid()));
            str.AppendLine(string.Format("DESCRIPTION:{0}", message.Body));
            str.AppendLine(string.Format("X-ALT-DESC;FMTTYPE=text/html:{0}", message.Body));
            str.AppendLine(string.Format("SUMMARY:{0}", message.Subject));
            str.AppendLine(string.Format("ORGANIZER:MAILTO:{0}", message.From.Address));

            str.AppendLine(string.Format("ATTENDEE;CN=\"{0}\";RSVP=TRUE:mailto:{1}", message.To[0].DisplayName, message.To[0].Address));

            str.AppendLine("BEGIN:VALARM");
            str.AppendLine("TRIGGER:-PT15M");
            str.AppendLine("ACTION:DISPLAY");
            str.AppendLine("DESCRIPTION:Reminder");
            str.AppendLine("END:VALARM");
            str.AppendLine("END:VEVENT");
            str.AppendLine("END:VCALENDAR");

            var contype = new System.Net.Mime.ContentType("text/calendar");
            contype.Parameters.Add("method", "REQUEST");
            contype.Parameters.Add("name", "Meeting.ics");
            var avCal = AlternateView.CreateAlternateViewFromString(str.ToString(), contype);
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
