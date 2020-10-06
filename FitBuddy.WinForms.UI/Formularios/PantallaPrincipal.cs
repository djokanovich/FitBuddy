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
        public PantallaPrincipal()
        {
            InitializeComponent();
            var customPrincipal = Thread.CurrentPrincipal as CustomPrincipal;
            lblWelcome.Text = $"Bienvenido, {customPrincipal.Identity.Name}";
        }

        private void OnBtnGestionarPerfilClick(object sender, EventArgs e)
        {
            var gesPerfil = new GestionarPerfil();
            gesPerfil.Show();
        }

        private void OnBtnGestionarPlanAlimenticioClick(object sender, EventArgs e)
        {
            var gesPlanAlim = new GestionarPlanAlimenticio();
            gesPlanAlim.Show();
        }

        private void OnBtnGestionarPlanEjercicioClick(object sender, EventArgs e)
        {
            var gesPlanEj = new GestionarPlanEjercicios();
            gesPlanEj.Show();
        }

        private void OnBtnCargaDiariaComidasClick(object sender, EventArgs e)
        {
            var cargaComidas = new CargarAlimento();
            cargaComidas.Show();
        }

        private void OnBtnCargaDiariaEjerciciosClick(object sender, EventArgs e)
        {
            var cargaEjercicio = new CargarDiarioEjercicios();
            cargaEjercicio.Show();
            
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
            var AgendaTurno = new AgendarTurno();
            AgendaTurno.Show();
        }

        private void OnBtnBackupClick(object sender, EventArgs e)
        {
            var backup = new Backup();
            backup.Show();
        }
    }
}
