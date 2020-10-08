using FitBuddy.WinForms.UI.Security;
using System;
using System.Threading;
using System.Windows.Forms;

namespace FitBuddy.WinForms.UI.Formularios
{
    public partial class GestionarPlanAlimenticio : Form
    {
        private readonly IFormBuilder _formBuilder;

        public GestionarPlanAlimenticio(IFormBuilder formBuilder)
        {
            InitializeComponent();
            var customPrincipal = Thread.CurrentPrincipal as CustomPrincipal;
            lblWelcome.Text = $"Usuario {customPrincipal.Identity.Name}";
            _formBuilder = formBuilder;
        }

        private void OnBtnCrearDietaClick(object sender, EventArgs e)
        {
            _formBuilder.Show<CrearDieta>();
        }

        private void OnBtnVerDietaClick(object sender, EventArgs e)
        {
            MessageBox.Show("Sección en construcción");
        }
    }
}
