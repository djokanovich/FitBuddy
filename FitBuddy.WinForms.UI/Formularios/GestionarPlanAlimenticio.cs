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
    public partial class GestionarPlanAlimenticio : Form
    {
        public GestionarPlanAlimenticio()
        {
            InitializeComponent();
            var customPrincipal = Thread.CurrentPrincipal as CustomPrincipal;
            lblWelcome.Text = $"Usuario {customPrincipal.Identity.Name}";
        }

        private void OnBtnCrearDietaClick(object sender, EventArgs e)
        {
            var crearDieta = new CrearDieta();
            crearDieta.Show();
        }

        private void OnBtnVerDietaClick(object sender, EventArgs e)
        {
            MessageBox.Show("Sección en construcción");
        }
    }
}
