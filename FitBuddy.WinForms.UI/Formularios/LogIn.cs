using Bitacora;
using BLL;
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
        public LogIn()
        {
            InitializeComponent();
        }

        private void OnBtnAceptarClick(object sender, EventArgs e)
        {
            var path = Properties.Settings.Default.ArchivoBitacora;

            var bitacora = new ServicioBitacora(path);
            

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
                bitacora.Agregar("Se ha logueado el usuario" + usuario.Username);
                pantallaprincipal.Show();
                this.Close();
            }
            else
            {
                // no loguearlo
                MessageBox.Show("Usuario o contraseña incorrectos");
                bitacora.Agregar("El usuario ha intentado ingresar al sistema sin éxito " + txtUsername.Text);
            }
        }

        private void OnLnkRegistrarUsuarioClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var registrar = new RegistrarNuevoUsuario();
            registrar.Show();
            this.Close();
        }
    }
}
