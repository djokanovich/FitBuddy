using Common.Bitacora;
using FitBuddy.Business.Facade;
using FitBuddy.WinForms.UI.Security;
using MetroFramework.Forms;
using System;
using System.Windows.Forms;

namespace FitBuddy.WinForms.UI.Formularios
{
    public partial class PantallaPrincipal : MetroForm
    {
        private readonly IFormManager _formManager;
        private readonly IBitacora<PantallaPrincipal> _bitacora;
        private readonly IPantallaPrincipalBusinessLogic _pantallaPrincipalBusinessLogic;

        public PantallaPrincipal(IFormManager formManager,
            IBitacora<PantallaPrincipal> bitacora,
            IPantallaPrincipalBusinessLogic pantallaPrincipalBusinessLogic)
        {
            InitializeComponent();
            lblWelcome.Text = $"Bienvenido, {IdentityManager.UsuarioActual.Username}";
            _formManager = formManager;
            _bitacora = bitacora;
            _pantallaPrincipalBusinessLogic = pantallaPrincipalBusinessLogic;
        }

        private void OnBtnGestionarPerfilClick(object sender, EventArgs e)
        {
            _formManager.Show<GestionarPerfil>();
        }

        private void OnBtnGestionarPlanAlimenticioClick(object sender, EventArgs e)
        {
            _formManager.Show<GestionarPlanAlimenticio>();
        }

        private void OnBtnGestionarPlanEjercicioClick(object sender, EventArgs e)
        {
            _formManager.Show<GestionarPlanEjercicios>();
        }

        private void OnBtnCargaDiariaComidasClick(object sender, EventArgs e)
        {
            _formManager.Show<CargarAlimento>();
        }

        private void OnBtnCargaDiariaEjerciciosClick(object sender, EventArgs e)
        {
            _formManager.Show<CargarDiarioEjercicios>();
        }

        private void OnBtnEstadisticasClick(object sender, EventArgs e)
        {
            var usuarioId = IdentityManager.UsuarioActual.UserId;
            if (_pantallaPrincipalBusinessLogic.PuedeMostrarEstadísticas(usuarioId))
            {
                _formManager.Show<Estadísticas>();
            }
            else
            {
                var dialogResult = MessageBox.Show("Para poder mostrar las estadísticas debe definir primero la altura, el peso, y la edad del paciente.\n\n¿Desea definir esos parámetros ahora?",
                    "No se pueden mostrar las estadísticas",
                    MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    _formManager.Show<GestionarPerfil>();
                }
            }
        }

        private void OnBtnContactarProfesionalClick(object sender, EventArgs e)
        {
            MessageBox.Show("Sección en construcción");
        }

        private void OnBtnReclamosSugerenciasClick(object sender, EventArgs e)
        {
            MessageBox.Show("Sección en construcción");
        }

        private void OnBtnAgendarTurnoClick(object sender, EventArgs e)
        {
            _formManager.Show<AgendarTurno>();
        }

        private void OnBtnBackupClick(object sender, EventArgs e)
        {
            _formManager.Show<Backup>();
        }

        private void OnBtnLogoutClick(object sender, EventArgs e)
        {
            _bitacora.Info($"El usuario {IdentityManager.UsuarioActual.Username} (id: {IdentityManager.UsuarioActual.UserId}) ha cerrado su sesión.");
            IdentityManager.CerrarSesionUsuario();
            MessageBox.Show(
                "Se ha cerrado la sesión.",
                "¡Atención!",
                MessageBoxButtons.OK);
            
            _formManager.Show<LogIn>().AndClose(this);
        }

        private void btnConfiguración_Click(object sender, EventArgs e)
        {
            _formManager.Show<Configuracion>();
        }
    }
}
