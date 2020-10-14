using FitBuddy.Business.Facade;
using FitBuddy.Entidades;
using FitBuddy.WinForms.UI.Security;
using System;
using System.Windows.Forms;

namespace FitBuddy.WinForms.UI.Formularios
{
    public partial class GestionarPerfil : Form
    {
        private readonly IFormManager _formManager;
        private readonly IGestionarPerfilBusinessLogic _gestionarPerfilBusinessLogic;

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

            var paciente = _gestionarPerfilBusinessLogic.ObtenerPacientePorUsuarioId(IdentityManager.UsuarioActual.UserId);

            if (paciente != null)
            {
                txtAltura.Text = paciente.Altura.ToString();
                txtBrazo.Text = paciente.ContBrazo.ToString();
                txtCadera.Text = paciente.ContCadera.ToString() ;
                txtCintura.Text = paciente.ContCintura.ToString();
                txtEdad.Text = paciente.Edad.ToString();
                txtMuslo.Text = paciente.ContMuslo.ToString();
                txtPeso.Text = paciente.Peso.ToString();
                dtpFecha.Value = paciente.FechaRegistroPerfil;
                if (paciente.Genero == Genero.Femenino) 
                {
                    radBtnFemenino.Checked  = true;
                }
                else
                {
                    radBtnMasculino.Checked = true;
                }
            }

            
        }


        private void OnBtnEnviarClick(object sender, EventArgs e)
        {
            var genero = Genero.NoEspecificado;
            if (radBtnFemenino.Checked)
            {
                genero = Genero.Femenino;
            }
            else if (radBtnMasculino.Checked)
            {
                genero = Genero.Femenino;
            }

            var userId = IdentityManager.UsuarioActual.UserId;
            var usuario = _gestionarPerfilBusinessLogic.ObtenerUsuarioPorId(userId);
            var paciente = new Paciente
            {
                UsuarioId = userId,
                Usuario = usuario,
                Peso = ConvertirAInt(txtPeso.Text),
                ContBrazo = ConvertirAInt(txtBrazo.Text),
                ContCadera = ConvertirAInt(txtCadera.Text),
                Altura = ConvertirAInt(txtAltura.Text),
                ContCintura = ConvertirAInt(txtCintura.Text),
                ContMuslo = ConvertirAInt(txtMuslo.Text),
                Edad = ConvertirAInt(txtEdad.Text),
                Genero = genero,
                FechaRegistroPerfil = Convert.ToDateTime(dtpFecha.Text) // TODO: ¿No debería ser DateTime.Now?
            };

            // Le paso a la BLL el paciente creado.
            _gestionarPerfilBusinessLogic.CrearPaciente(paciente);

            MessageBox.Show("Datos cargados con éxito");
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

        private void GestionarPerfil_Load(object sender, EventArgs e)
        {

        }
    }
}
