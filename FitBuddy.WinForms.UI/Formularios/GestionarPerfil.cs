using FitBuddy.Business.Facade;
using FitBuddy.Entidades;
using FitBuddy.Entidades.Enums;
using FitBuddy.WinForms.UI.Security;
using System;
using System.Windows.Forms;

namespace FitBuddy.WinForms.UI.Formularios
{
    public partial class GestionarPerfil : Form
    {
        private readonly IFormManager _formManager;
        private readonly IGestionarPerfilBusinessLogic _gestionarPerfilBusinessLogic;
        private Paciente _paciente;

        public GestionarPerfil(IFormManager formManager, IGestionarPerfilBusinessLogic gestionarPerfilBusinessLogic)
        {
            InitializeComponent();
            lblWelcome.Text = $"Usuario {IdentityManager.UsuarioActual.Username}";
            _formManager = formManager;
            _gestionarPerfilBusinessLogic = gestionarPerfilBusinessLogic;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            dtpFecha.Value = DateTime.Now;

            var usuarioId = IdentityManager.UsuarioActual.UserId;
            _paciente = _gestionarPerfilBusinessLogic.ObtenerPacienteAsociadoAUsuario(usuarioId);

            if (_paciente == null)
            {
                lblRegistroAnterior.Text = "Este será el primer registro del perfil.";
                return;
            }

            txtAltura.Text = _paciente.Altura.ToString();
            txtBrazo.Text = _paciente.ContornoBrazoEnCm.ToString();
            txtCadera.Text = _paciente.ContornoCaderaEnCm.ToString();
            txtCintura.Text = _paciente.ContornoCinturaEnCm.ToString();
            txtEdad.Text = _paciente.Edad.ToString();
            txtMuslo.Text = _paciente.ContornoMusloEnCm.ToString();
            txtPeso.Text = _paciente.Peso.ToString();

            var últimaActualización = _paciente.FechaRegistroPerfil.ToString("ddd, d MMM yyyy");
            var díasAtrás = (DateTime.Today - _paciente.FechaRegistroPerfil).Days;
            lblRegistroAnterior.Text = $"Última actualización del perfil: {últimaActualización}.\n(Hace {díasAtrás} días.)";

            if (_paciente.Genero == Genero.Femenino)
            {
                radBtnFemenino.Checked = true;
            }
            else if (_paciente.Genero == Genero.Masculino)
            {
                radBtnMasculino.Checked = true;
            }
        }

        private void OnBtnGuardarClick(object sender, EventArgs e)
        {
            var usuarioId = IdentityManager.UsuarioActual.UserId;

            var genero = Genero.NoEspecificado;
            if (radBtnFemenino.Checked)
            {
                genero = Genero.Femenino;
            }
            else if (radBtnMasculino.Checked)
            {
                genero = Genero.Femenino;
            }

            if (_paciente == null)
                _paciente = new Paciente();

            _paciente.Peso = ConvertirAInt(txtPeso.Text);
            _paciente.ContornoBrazoEnCm = ConvertirAInt(txtBrazo.Text);
            _paciente.ContornoCaderaEnCm = ConvertirAInt(txtCadera.Text);
            _paciente.Altura = ConvertirAInt(txtAltura.Text);
            _paciente.ContornoCinturaEnCm = ConvertirAInt(txtCintura.Text);
            _paciente.ContornoMusloEnCm = ConvertirAInt(txtMuslo.Text);
            _paciente.Edad = ConvertirAInt(txtEdad.Text);
            _paciente.Genero = genero;
            _paciente.FechaRegistroPerfil = Convert.ToDateTime(dtpFecha.Text);

            // Le paso a la BLL el paciente creado.
            var éxito = _gestionarPerfilBusinessLogic.CrearOActualizarPacienteAsociadoAUsuario(usuarioId, _paciente);

            if (éxito)
            {
                MessageBox.Show("Datos cargados con éxito");
            } // TODO: else?

            _formManager.Close(this);
        }

        private void OnBtnLimpiarClick(object sender, EventArgs e)
        {
            BorrarCampos();
        }

        private int ConvertirAInt(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                return 0;
            }

            return int.Parse(s);
        }

        private void BorrarCampos()
        {
            txtEdad.Text = null;
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
