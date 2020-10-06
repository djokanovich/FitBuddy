﻿using FitBuddy.WinForms.UI.Security;
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
    public partial class GestionarPlanEjercicios : Form
    {
        public GestionarPlanEjercicios()
        {
            InitializeComponent();
            var customPrincipal = Thread.CurrentPrincipal as CustomPrincipal;
            lblWelcome.Text = $"Usuario {customPrincipal.Identity.Name}";
        }

        private void OnBtnCrearPlanClick(object sender, EventArgs e)
        {
            var crearPlanEj = new CrearPlanEjercicio();
            crearPlanEj.Show();
        }

        private void OnBtnVerPlanClick(object sender, EventArgs e)
        {
            MessageBox.Show("Sección en construcción");
        }
    }
}