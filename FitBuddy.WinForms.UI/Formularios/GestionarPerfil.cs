using FitBuddy.Business.Facade;
using FitBuddy.Entidades;
using FitBuddy.Entidades.Enums;
using FitBuddy.WinForms.UI.ExtensionMethods;
using FitBuddy.WinForms.UI.Security;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FitBuddy.WinForms.UI.Formularios
{
    public partial class GestionarPerfil : MetroForm
    {
        private readonly IFormManager _formManager;
        private readonly IGestionarPerfilBusinessLogic _gestionarPerfilBusinessLogic;
        private Paciente _paciente;

        public GestionarPerfil(IFormManager formManager, IGestionarPerfilBusinessLogic gestionarPerfilBusinessLogic)
        {
            InitializeComponent();
            lblWelcome.FormatearControl(IdentityManager.UsuarioActual.Username);
            _formManager = formManager;
            _gestionarPerfilBusinessLogic = gestionarPerfilBusinessLogic;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // No se pueden seleccionar fechas futuras.
            dtpFechaRegistro.MaxDate = DateTime.Today;
            dtpFechaNacimiento.MaxDate = DateTime.Today;

            // Asumir que se quieren registrar datos del día corriente.
            dtpFechaRegistro.Value = DateTime.Today;

            var usuarioId = IdentityManager.UsuarioActual.UserId;
            _paciente = _gestionarPerfilBusinessLogic.ObtenerPacienteAsociadoAUsuario(usuarioId);

            if (_paciente == null)
            {
                // Aún no se ha creado un paciente asociado al usuario.
                lblRegistroAnterior.FormatearControl(0);
                dtpFechaNacimiento.Value = new DateTime(DateTime.Today.AddYears(-30).Year, 1, 1);
                lblEdad.Text = string.Empty;
                return;
            }

            dtpFechaNacimiento.Value = _paciente.FechaNacimiento;
            lblEdad.FormatearControl(_paciente.Edad.ToString());

            if (_paciente.Género == Género.Femenino)
            {
                radBtnFemenino.Checked = true;
            }
            else if (_paciente.Género == Género.Masculino)
            {
                radBtnMasculino.Checked = true;
            }

            var últimoRegistroDelPaciente = _paciente.ÚltimoRegistro();
            if (últimoRegistroDelPaciente == null)
            {
                // Se ha creado un paciente asociado al usuario, pero no hay registros acerca del peso, la altura, etc.
                lblRegistroAnterior.FormatearControl(1);
                return;
            }

            var fechaÚltimoRegistro = últimoRegistroDelPaciente.FechaRegistro.ToString("ddd, d MMM yyyy");
            var díasAtrás = (DateTime.Today - últimoRegistroDelPaciente.FechaRegistro).Days;
            lblRegistroAnterior.FormatearControl(2, fechaÚltimoRegistro, díasAtrás.ToString());

            txtAltura.Text = últimoRegistroDelPaciente.AlturaEnCm.ToString();
            txtPeso.Text = últimoRegistroDelPaciente.PesoEnKg.ToString();
            txtBrazo.Text = últimoRegistroDelPaciente.ContornoBrazoEnCm.ToString();
            txtCadera.Text = últimoRegistroDelPaciente.ContornoCaderaEnCm.ToString();
            txtCintura.Text = últimoRegistroDelPaciente.ContornoCinturaEnCm.ToString();
            txtMuslo.Text = últimoRegistroDelPaciente.ContornoMusloEnCm.ToString();
        }

        private void OnBtnGuardarClick(object sender, EventArgs e)
        {
            var usuarioId = IdentityManager.UsuarioActual.UserId;

            var genero = Género.NoEspecificado;
            if (radBtnFemenino.Checked)
            {
                genero = Género.Femenino;
            }
            else if (radBtnMasculino.Checked)
            {
                genero = Género.Femenino;
            }

            if (_paciente == null)
                _paciente = new Paciente();

            _paciente.Género = genero;
            _paciente.FechaNacimiento = dtpFechaNacimiento.Value;

            var historialPaciente = new HistorialPaciente
            {
                FechaRegistro = dtpFechaRegistro.Value,
                PesoEnKg = ConvertirAInt(txtPeso.Text),
                AlturaEnCm = ConvertirAInt(txtAltura.Text),
                ContornoBrazoEnCm = ConvertirAInt(txtBrazo.Text),
                ContornoCaderaEnCm = ConvertirAInt(txtCadera.Text),
                ContornoCinturaEnCm = ConvertirAInt(txtCintura.Text),
                ContornoMusloEnCm = ConvertirAInt(txtMuslo.Text),
            };

            if (HistorialPacienteTieneDatosRelevantes(_paciente.HistorialPaciente, historialPaciente))
                _paciente.HistorialPaciente.Add(historialPaciente);

            // Le paso a la BLL el paciente creado.
            var éxito = _gestionarPerfilBusinessLogic.CrearOActualizarPacienteAsociadoAUsuario(usuarioId, _paciente);

            if (éxito)
                MessageBox.Show("Datos cargados con éxito.");
            else
                MessageBox.Show("No se ha podido guardar los cambios. Si el problema persiste, notifique a un administrador.");

            _formManager.Close(this);
        }

        private bool HistorialPacienteTieneDatosRelevantes(List<HistorialPaciente> historialPaciente, HistorialPaciente historialAAgregar)
        {
            var esHistorialVacío = !historialPaciente.Any();
            var todosLosValoresIngresadosSonCero = historialAAgregar.AlturaEnCm == 0 &&
                historialAAgregar.PesoEnKg == 0 &&
                historialAAgregar.ContornoBrazoEnCm == 0 &&
                historialAAgregar.ContornoCaderaEnCm == 0 &&
                historialAAgregar.ContornoCinturaEnCm == 0 &&
                historialAAgregar.ContornoMusloEnCm == 0;

            if (esHistorialVacío && todosLosValoresIngresadosSonCero)
                return false;

            // TODO: Pasar esta directiva de preproceso a la configuración de la aplicación:
#if GUARDAR_DATOS_DUPLICADOS_EN_HISTORIAL_PACIENTE
            if (esHistorialVacío)
                return true;

            var últimoRegistro = historialPaciente.OrderByDescending(hp => hp.FechaRegistro).First();

            var hayDatosNuevos = últimoRegistro.AlturaEnCm != historialAAgregar.AlturaEnCm ||
                últimoRegistro.PesoEnKg != historialAAgregar.PesoEnKg ||
                últimoRegistro.ContornoBrazoEnCm != historialAAgregar.ContornoBrazoEnCm ||
                últimoRegistro.ContornoCaderaEnCm != historialAAgregar.ContornoCaderaEnCm ||
                últimoRegistro.ContornoCinturaEnCm != historialAAgregar.ContornoCinturaEnCm ||
                últimoRegistro.ContornoMusloEnCm != historialAAgregar.ContornoMusloEnCm;

            return hayDatosNuevos;
#else
            return true;
#endif
        }

        private void OnBtnLimpiarClick(object sender, EventArgs e)
        {
            BorrarCampos();
        }

        private int ConvertirAInt(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                return 0;

            return int.Parse(s);
        }

        private void BorrarCampos()
        {
            txtPeso.Text = null;
            txtAltura.Text = null;
            txtCintura.Text = null;
            txtCadera.Text = null;
            txtMuslo.Text = null;
            txtBrazo.Text = null;
        }

        private void lnkInstrucciones_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=IxrRGDIh_mM");
        }

        private void OnBtnAtrasClick(object sender, EventArgs e)
        {
            _formManager.Close(this);
        }
    }
}
