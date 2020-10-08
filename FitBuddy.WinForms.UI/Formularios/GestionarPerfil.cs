using FitBuddy.Business;
using FitBuddy.Entidades;
using FitBuddy.WinForms.UI.Security;
using System;
using System.Windows.Forms;

namespace FitBuddy.WinForms.UI.Formularios
{
    public partial class GestionarPerfil : Form
    {
        private readonly IUsuarioFacade _usuarioFacade;
        private readonly PacienteFacade _gesPaciente;

        public GestionarPerfil(IUsuarioFacade usuarioFacade, PacienteFacade gesPaciente)
        {
            InitializeComponent();
            lblWelcome.Text = $"Usuario {IdentityManager.UsuarioActual.Username}";
            _usuarioFacade = usuarioFacade;
            _gesPaciente = gesPaciente;
        }

        public void Clear()
        {
            txtEdad.Text = null;
            txtPeso.Text = null;
            txtAltura.Text = null;
            txtCintura.Text = null;
            txtCadera.Text = null;
            txtMuslo.Text = null;
            txtBrazo.Text = null;
        }

        private void OnBtnEnviarClick(object sender, EventArgs e)
        {
            var genero = ((RadioButton)grpBoxSexo.Controls[0]).Checked ? "F" : "M"; // Operador condicional ternario

            var userId = IdentityManager.UsuarioActual.UserId;
            var usuario = _usuarioFacade.ObtenerUsuario(userId);
            Paciente paciente = new Paciente
            {
                UsuarioId = userId,
                Usuario = usuario,
                Peso = Convert.ToInt32(txtPeso.Text),
                ContBrazo = Convert.ToInt32(txtBrazo.Text),
                ContCadera = Convert.ToInt32(txtCadera.Text),
                Altura = Convert.ToInt32(txtAltura.Text),
                ContCintura = Convert.ToInt32(txtCintura.Text),
                ContMuslo = Convert.ToInt32(txtMuslo.Text),
                Edad = Convert.ToInt32(txtEdad.Text),
                Genero = genero,
                FechaRegistroPerfil = Convert.ToDateTime(dtpFecha.Text)
            };

            // le paso a la BLL el paciente creado
            _gesPaciente.CrearPaciente(paciente);


            MessageBox.Show("Datos cargados con éxito");
            Clear();
        }

        private void OnBtnLimpiarClick(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
