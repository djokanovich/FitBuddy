using Common.Bitacora;
using FitBuddy.Business.Facade;
using FitBuddy.Entidades;
using System;
using System.Windows.Forms;

namespace FitBuddy.WinForms.UI.Formularios
{
    public partial class RegistrarNuevoUsuario : Form
    {
        private readonly IFormManager _formManager;
        private readonly IBitacora<RegistrarNuevoUsuario> _bitacora;
        private readonly IRegistrarNuevoUsuarioBusinessLogic _registrarNuevoUsuarioBusinessLogic;

        public RegistrarNuevoUsuario(IFormManager formManager,
            IBitacora<RegistrarNuevoUsuario> bitacora,
            IRegistrarNuevoUsuarioBusinessLogic registrarNuevoUsuarioBusinessLogic)
        {
            InitializeComponent();
            _formManager = formManager;
            _bitacora = bitacora;
            _registrarNuevoUsuarioBusinessLogic = registrarNuevoUsuarioBusinessLogic;
        }

        private void OnBtnRegistrarClick(object sender, EventArgs e)
        {
            if (!SonCamposVálidos())
                return;

            var usuario = new Usuario
            {
                Username = txtUsername.Text,
                Apellido = txtApellido.Text,
                Nombre = txtNombre.Text
            };
            var contraseña = txtPassword.Text;

            if (_registrarNuevoUsuarioBusinessLogic.EsUsuarioGuardadoConÉxito(usuario, contraseña))
            {
                _bitacora.Info($"Se ha registrado el usuario {usuario.Username} con éxito.");
                MessageBox.Show($"El usuario {usuario.Username} fue registrado con éxito.");
                _formManager.Show<LogIn>().AndClose(this);
            }
            else
            {
                MessageBox.Show("El usuario no fue registrado.");
                BorrarCampos();
            }
        }

        private bool SonCamposVálidos()
        {
            var username = txtUsername.Text;
            if (EsCampoVacío(username, "un nombre de usuario"))
                return false;

            var nombre = txtNombre.Text;
            if (EsCampoVacío(nombre, "el nombre del usuario"))
                return false;

            var apellido = txtApellido.Text;
            if (EsCampoVacío(apellido, "el apellido del usuario"))
                return false;

            var contraseña = txtPassword.Text;
            var contraseñaRepetida = txtRepeatPassword.Text;
            if (contraseña != contraseñaRepetida)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                BorrarCampos();
                return false;
            }

            if (!_registrarNuevoUsuarioBusinessLogic.EsContraseñaVálida(contraseña))
            {
                MessageBox.Show($"La contraseña no es segura. Inserte una contraseña con al menos {_registrarNuevoUsuarioBusinessLogic.ContraseñaLongitudMínima} caracteres, un dígito, y una mayúscula.");
                return false;
            }

            string email = txtEmail.Text;
            if (!_registrarNuevoUsuarioBusinessLogic.EsEmailVálido(email))
            {
                MessageBox.Show("Debe introducir un correo válido");
                return false;
            }

            return true;
        }

        private bool EsCampoVacío(string campo, string descripción)
        {
            if (string.IsNullOrWhiteSpace(campo))
            {
                MessageBox.Show($"Debe ingresar {descripción}.");
                return true;
            }

            return false;
        }

        private void BorrarCampos()
        {
            txtUsername.Text = string.Empty;
            txtRepeatPassword.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
        }
    }
}
