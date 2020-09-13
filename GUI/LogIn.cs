using DAL.Services;
using GUI.Security;
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

namespace GUI
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            var usuarioDataService = new UsuarioDataService();
            var usuario = usuarioDataService.GetUsuarioByNameAndPassword(txtUsername.Text, txtPassword.Text);
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
                customPrincipal.Identity = new CustomIdentity(usuario.Username, null);

                var pantallaprincipal = new PantallaPrincipal();
                MessageBox.Show("Logueado correctamente");
                pantallaprincipal.Show(); 
            }
            else
            {
                // no loguearlo
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var registrar = new RegistrarNuevoUsuario();
            registrar.Show();
            this.Close();
        }
    }
}
