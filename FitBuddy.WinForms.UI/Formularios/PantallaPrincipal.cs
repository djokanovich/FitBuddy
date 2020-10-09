﻿using FitBuddy.Business.Facade;
using FitBuddy.WinForms.UI.Security;
using System;
using System.Windows.Forms;

namespace FitBuddy.WinForms.UI.Formularios
{
    public partial class PantallaPrincipal : Form
    {
        private readonly IFormManager _formManager;
        private readonly IPantallaPrincipalBusinessLogic _pantallaPrincipalBusinessLogic;

        public PantallaPrincipal(IFormManager formManager, IPantallaPrincipalBusinessLogic pantallaPrincipalBusinessLogic)
        {
            InitializeComponent();
            lblWelcome.Text = $"Bienvenido, {IdentityManager.UsuarioActual.Username}";
            _formManager = formManager;
            _pantallaPrincipalBusinessLogic = pantallaPrincipalBusinessLogic;
        }

        private void OnBtnGestionarPerfilClick(object sender, EventArgs e)
        {
            _formManager.Show<GestionarPerfil>();
        }

        private void OnBtnGestionarPlanAlimenticioClick(object sender, EventArgs e)
        {
            _formManager.Show<GestionarPlanAlimenticio>();
        }

        private void OnBtnGestionarPlanEjercicioClick(object sender, EventArgs e)
        {
            _formManager.Show<GestionarPlanEjercicios>();
        }

        private void OnBtnCargaDiariaComidasClick(object sender, EventArgs e)
        {
            _formManager.Show<CargarAlimento>();
        }

        private void OnBtnCargaDiariaEjerciciosClick(object sender, EventArgs e)
        {
            _formManager.Show<CargarDiarioEjercicios>();
        }

        private void OnBtnEstadisticasClick(object sender, EventArgs e)
        {
            if (_pantallaPrincipalBusinessLogic.AlturaPesoEdadPacienteDefinidos(IdentityManager.UsuarioActual.UserId))
            {
                _formManager.Show<Estadísticas>();
            }
            else
            {
                var dialogResult = MessageBox.Show("Para poder mostrar las estadísticas debe definir primero la altura, el peso, y la edad del paciente.\n\n¿Desea definir esos parámetros ahora?",
                    "No se pueden mostrar las estadísticas",
                    MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    _formManager.Show<GestionarPerfil>();
                }
            }
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
            _formManager.Show<AgendarTurno>();
        }

        private void OnBtnBackupClick(object sender, EventArgs e)
        {
            _formManager.Show<Backup>();
        }
    }
}
