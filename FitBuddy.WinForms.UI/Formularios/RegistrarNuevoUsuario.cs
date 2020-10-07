using Common.Bitacora;
using FitBuddy.Business;
using FitBuddy.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitBuddy.WinForms.UI.Formularios
{
    public partial class RegistrarNuevoUsuario : Form
    {
        private readonly IBitacora _bitacora;

        public RegistrarNuevoUsuario(IBitacora bitacora)
        {
            InitializeComponent();
            _bitacora = bitacora;
        }

        public void BorrarTodo()
        {
            txtApellido.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtRepeatPassword.Text = string.Empty;
            txtUsuario.Text = string.Empty;
        }

        private void OnBtnRegistrarClick(object sender, EventArgs e)
        {
            if (!txtPassword.Text.Equals(txtRepeatPassword.Text))
            {
                MessageBox.Show("Las contraseñas no coinciden");
                BorrarTodo();
                return;
            }

            var hasNumber = new Regex(@"[0-9]");
            var hasUpperChar = new Regex(@"[A-Z]");

            if (txtPassword.Text.Length < 8 || !hasNumber.Match(txtPassword.Text).Success || !hasUpperChar.Match(txtPassword.Text).Success)
            {
                MessageBox.Show("La contraseña no es segura. Inserte una contraseña con al menos 8 caracteres, un número y una mayúscula.");
                return;
            }

            // TODO: Implementar una validación mejor
            if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains(".com"))
            {
                MessageBox.Show("Debe introducir un correo válido");
                return;
            }

            var usuario = new Usuario
            {
                Username = txtUsuario.Text,
                Apellido = txtApellido.Text,
                Nombre = txtNombre.Text
            };

            var gesUsuario = new gesUsuario();
            if (gesUsuario.GuardarUsuario(usuario, txtPassword.Text) > 0)
            {
                MessageBox.Show("El usuario fue registrado con éxito");
                _bitacora.Agregar($"Se ha registrado el usuario {usuario.Username} con éxito");
                var logIn = new LogIn(_bitacora);
                logIn.Show();
                Close();
            }
            else
            {
                MessageBox.Show("El usuario no fue registrado");

                BorrarTodo();
            }
        }
    }
}
