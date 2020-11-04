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

            var username = txtUsername.Text;

            if (_registrarNuevoUsuarioBusinessLogic.ExisteNombreDeUsuario(username))
            {
                MessageBox.Show($"El nombre de usuario '{username}' ya existe. Elija otro nombre de usuario.");
                return;
            }

            var usuario = new Usuario
            {
                Username = username,
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Estado = Estado.Activo,
                IntentosFallidos = 0,
                IdIdioma = 0 // TODO: Agregar idiomas a la tabla idiomas, mostrarlos en un combobox en este formulario, y setear este campo al valor seleccionado
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
                _bitacora.Error($"Error al intentar crear el usuario '{username}' con nombre: '{usuario.Nombre}', apellido: '{usuario.Apellido}'.");
                MessageBox.Show("El usuario no pudo ser creado. Si el problema persiste, notifique a un administrador.");
                BorrarCampos();
            }
        }

        private bool SonCamposVálidos()
        {
            var username = txtUsername.Text;
            if (EsCampoVacío(username, "un nombre de usuario (username)"))
                return false;

            var contraseña = txtPassword.Text;
            var contraseñaRepetida = txtRepeatPassword.Text;
            if (contraseña != contraseñaRepetida)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
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

            var nombre = txtNombre.Text;
            if (EsCampoVacío(nombre, "el nombre de pila del usuario"))
                return false;

            var apellido = txtApellido.Text;
            if (EsCampoVacío(apellido, "el apellido del usuario"))
                return false;

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

        private void OnBtnAtrásClick(object sender, EventArgs e)
        {
            _formManager.Show<LogIn>().AndClose(this);
        }
    }
}
