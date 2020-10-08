﻿using FitBuddy.Business;
using FitBuddy.WinForms.UI.Security;
using System;
using System.Windows.Forms;

namespace FitBuddy.WinForms.UI.Formularios
{
    public partial class AgendarTurno : Form
    {
        private readonly IFormManager _formManager;
        private readonly IMedicoFacade _medicoFacade;

        public AgendarTurno(IFormManager formManager, IMedicoFacade medicoFacade)
        {
            InitializeComponent();
            lblWelcome.Text = $"Usuario {IdentityManager.UsuarioActual.Username}";
            _formManager = formManager;
            _medicoFacade = medicoFacade;
        }

        private void OnAgendarTurnoLoad(object sender, EventArgs e)
        {
            var medicos = _medicoFacade.ObtenerMedicos();
            cmbMedico.DataSource = medicos;
            cmbMedico.DisplayMember = "Nombre";
            cmbMedico.ValueMember = "Email";

            cmbFranjaHoraria.Items.Add("9:00");
            cmbFranjaHoraria.Items.Add("10:00");
            cmbFranjaHoraria.Items.Add("11:00");
            cmbFranjaHoraria.Items.Add("12:00");
            cmbFranjaHoraria.Items.Add("13:00");
            cmbFranjaHoraria.Items.Add("14:00");
        }

        private void OnBtnEnviarClick(object sender, EventArgs e)
        {
            // TODO: Implementar.
            MessageBox.Show("Turno cargado con éxito, un administrador se pondrá en contacto para coordinar tu cita.");
            BorrarCampos();
        }

        private void BorrarCampos()
        {
            cmbFranjaHoraria.Text = string.Empty;
            cmbMedico.Text = string.Empty;
        }

        private void OnBtnAtrasClick(object sender, EventArgs e)
        {
            _formManager.Close(this);
        }
    }
}
