using FitBuddy.Business.Facade;
using FitBuddy.Business.Modelos;
using FitBuddy.WinForms.UI.ExtensionMethods;
using FitBuddy.WinForms.UI.Security;
using MetroFramework.Forms;
using System;
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
            lblWelcome.FormatearControl(IdentityManager.UsuarioActual.Username);
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
            var host = Properties.Settings.Default.SmtpClientHost;
            var port = Properties.Settings.Default.SmtpClientPort;
            var email = Properties.Settings.Default.NetworkCredentialsEmail;
            var password = Properties.Settings.Default.NetworkCredentialsPassword;

            var agendarTurnoModelo = new AgendarTurnoModelo
            {
                NombrePaciente = IdentityManager.UsuarioActual.Name,
                NombreMédico = cmbMedico.SelectedValue?.ToString(),
                EmailMédico = cmbMedico.Text,
                Fecha = dtpFecha.Value,
                Hora = cmbFranjaHoraria.Text,
                SmtpClientHost = _agendarTurnoBusinessLogic.LimpiarClave(host),
                SmtpClientPort = port,
                NetworkCredentialsEmail = _agendarTurnoBusinessLogic.LimpiarClave(email),
                NetworkCredentialsPassword = _agendarTurnoBusinessLogic.LimpiarClave(password),
                Mensaje = Properties.Resources.TemplateCorreo
            };

            if (_agendarTurnoBusinessLogic.EnviarCitaPorEmail(agendarTurnoModelo))
            {
                MessageBox.Show("Turno cargado con éxito, un administrador se pondrá en contacto para coordinar tu cita.");
                _formManager.Close(this);
            }
            else
            {
                MessageBox.Show("No se ha podido registrar el turno. Intente nuevamente y, si el problema persiste, contacte a un administrador.");
                BorrarCampos();
            }
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
