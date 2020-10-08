using Common.Bitacora;
using FitBuddy.Business;
using FitBuddy.WinForms.UI.Security;
using System;
using System.Threading;
using System.Windows.Forms;

namespace FitBuddy.WinForms.UI.Formularios
{
    public partial class LogIn : Form
    {
        private readonly IFormBuilder _formBuilder;
        private readonly IBitacora _bitacora;
        private readonly gesUsuario _gesUsuario;

        public LogIn(IFormBuilder formBuilder, IBitacora bitacora, gesUsuario gesUsuario)
        {
            InitializeComponent();
            _formBuilder = formBuilder;
            _bitacora = bitacora;
            _gesUsuario = gesUsuario;
        }

        private void OnBtnAceptarClick(object sender, EventArgs e)
        {
            var usuario = _gesUsuario.UsuarioAutenticado(txtUsername.Text, txtPassword.Text);
            if (usuario != null)
            {
                // el usuario existe => tiene acceso
                var customPrincipal = Thread.CurrentPrincipal as CustomPrincipal;
                if (customPrincipal == null)
                {
                    throw new ArgumentException("The application's default thread principal must be set to a CustomPrincipal object on startup.");
                }

                //Authenticate the user
                // TODO: Definir los roles
                customPrincipal.Identity = new CustomIdentity(usuario.Id, usuario.Username, null);

                _bitacora.Info($"Se ha logueado el usuario {usuario.Username}.");
                MessageBox.Show("Logueado correctamente.");
                _formBuilder.Show<PantallaPrincipal>();
                Close();
            }
            else
            {
                // no loguearlo
                _bitacora.Debug($"El usuario '{txtUsername.Text}' ha intentado ingresar al sistema sin éxito.");
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }
        }

        private void OnLnkRegistrarUsuarioClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _formBuilder.Show<RegistrarNuevoUsuario>();
            Close();
        }
    }
}
