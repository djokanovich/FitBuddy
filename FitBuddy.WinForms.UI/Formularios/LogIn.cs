using Common.Bitacora;
using FitBuddy.Business;
using FitBuddy.WinForms.UI.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitBuddy.WinForms.UI.Formularios
{
    public partial class LogIn : Form
    {
        private readonly IBitacora _bitacora;
        private readonly RegistrarNuevoUsuario _registrarNuevoUsuario;

        public LogIn(IBitacora bitacora, RegistrarNuevoUsuario registrarNuevoUsuario)
        {
            InitializeComponent();
            _bitacora = bitacora;
            _registrarNuevoUsuario = registrarNuevoUsuario;
        }

        private void OnBtnAceptarClick(object sender, EventArgs e)
        {
            var gesUsuario = new gesUsuario();
            var usuario = gesUsuario.UsuarioAutenticado(txtUsername.Text, txtPassword.Text);
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

                var pantallaprincipal = new PantallaPrincipal();
                MessageBox.Show("Logueado correctamente");
                _bitacora.Agregar("Se ha logueado el usuario" + usuario.Username);
                pantallaprincipal.Show();
                this.Close();
            }
            else
            {
                // no loguearlo
                MessageBox.Show("Usuario o contraseña incorrectos");
                _bitacora.Agregar("El usuario ha intentado ingresar al sistema sin éxito " + txtUsername.Text);
            }
        }

        private void OnLnkRegistrarUsuarioClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _registrarNuevoUsuario.Show();
            Close();
        }
    }
}
