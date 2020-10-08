using FitBuddy.WinForms.UI.Security;
using System;
using System.Windows.Forms;

namespace FitBuddy.WinForms.UI.Formularios
{
    public partial class PantallaPrincipal : Form
    {
        private readonly IFormManager _formBuilder;

        public PantallaPrincipal(IFormManager formBuilder)
        {
            InitializeComponent();
            lblWelcome.Text = $"Bienvenido, {IdentityManager.UsuarioActual.Username}";
            _formBuilder = formBuilder;
        }

        private void OnBtnGestionarPerfilClick(object sender, EventArgs e)
        {
            _formBuilder.Show<GestionarPerfil>();
        }

        private void OnBtnGestionarPlanAlimenticioClick(object sender, EventArgs e)
        {
            _formBuilder.Show<GestionarPlanAlimenticio>();
        }

        private void OnBtnGestionarPlanEjercicioClick(object sender, EventArgs e)
        {
            _formBuilder.Show<GestionarPlanEjercicios>();
        }

        private void OnBtnCargaDiariaComidasClick(object sender, EventArgs e)
        {
            _formBuilder.Show<CargarAlimento>();
        }

        private void OnBtnCargaDiariaEjerciciosClick(object sender, EventArgs e)
        {
            _formBuilder.Show<CargarDiarioEjercicios>();
        }

        private void OnBtnEstadisticasClick(object sender, EventArgs e)
        {
            _formBuilder.Show<Estadisticas>();
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
            _formBuilder.Show<AgendarTurno>();
        }

        private void OnBtnBackupClick(object sender, EventArgs e)
        {
            _formBuilder.Show<Backup>();
        }
    }
}
