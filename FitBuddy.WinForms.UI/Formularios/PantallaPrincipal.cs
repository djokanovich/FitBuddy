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
    public partial class PantallaPrincipal : Form
    {
        private readonly IFormBuilder _formBuilder;

        public PantallaPrincipal(IFormBuilder formBuilder)
        {
            InitializeComponent();
            var customPrincipal = Thread.CurrentPrincipal as CustomPrincipal;
            lblWelcome.Text = $"Bienvenido, {customPrincipal.Identity.Name}";
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
            MessageBox.Show("Sección en construcción");
            return;
        }

        private void OnBtnContactarProfesionalClick(object sender, EventArgs e)
        {
            MessageBox.Show("Sección en construcción");
            return;
        }

        private void OnBtnReclamosSugerenciasClick(object sender, EventArgs e)
        {
            MessageBox.Show("Sección en construcción");
            return;
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
