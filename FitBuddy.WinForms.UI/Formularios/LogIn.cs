using Common.Bitacora;
using FitBuddy.Business.Facade;
using FitBuddy.WinForms.UI.Security;
using MetroFramework.Forms;
using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace FitBuddy.WinForms.UI.Formularios
{
    public partial class LogIn : MetroForm
    {
        private readonly IFormManager _formManager;
        private readonly IBitacora<LogIn> _bitacora;
        private readonly ILogInBusinessLogic _logInBusinessLogic;

        public LogIn(IFormManager formManager, IBitacora<LogIn> bitacora, ILogInBusinessLogic logInBusinessLogic)
        {
            InitializeComponent();
            _formManager = formManager;
            _bitacora = bitacora;
            _logInBusinessLogic = logInBusinessLogic;
        }

        private void OnBtnAceptarClick(object sender, EventArgs e)
        {
            string plainPassword = txtPassword.Text;
            if (string.IsNullOrWhiteSpace(plainPassword))
            {
                MessageBox.Show("Debe ingresar la contraseña.");
                return;
            }

            string username = txtUsername.Text;
            var (usuario, autenticaciónExitosa) = _logInBusinessLogic.AutenticarUsuarioConContraseña(username, plainPassword);

            if (autenticaciónExitosa)
            {
                _bitacora.Info($"Se ha logueado el usuario {usuario.Username} (id: {usuario.Id}).");

                SetearIdioma(usuario.Idioma.Código);

                IdentityManager.IniciarSesionUsuario(usuario.Id, usuario.Username, null);

                MessageBox.Show("Logueado correctamente.");

                _formManager.Show<PantallaPrincipal>().AndClose(this);
            }
            else
            {
                _logInBusinessLogic.IntentoFallidoDeLogin(usuario);
                _bitacora.Debug($"El usuario '{username}' (ID: {usuario.Id}) ha intentado ingresar al sistema sin éxito.");
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }
        }

        private void SetearIdioma(string código)
        {
            var cultureInfo = new CultureInfo(código);

            Thread.CurrentThread.CurrentCulture = cultureInfo;
            Thread.CurrentThread.CurrentUICulture = cultureInfo;

            CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
            CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;
        }

        private void OnLnkRegistrarUsuarioClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _formManager.Show<RegistrarNuevoUsuario>().AndClose(this);
        }

        private void OnLnkOlvideContrasenaClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // TODO Implementar olvidé contraseña.
            MessageBox.Show("Contacte a un administrador.");
        }

        private void OnLnkAcercaDeClick(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _formManager.Show<AcercaDe>().AndClose(this);
        }

        private void OnBtnCancelarClick(object sender, EventArgs e)
        {
            _formManager.Close(this);
        }
    }
}
