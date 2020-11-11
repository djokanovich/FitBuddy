using FitBuddy.WinForms.UI.Security;
using MetroFramework.Forms;
using System;

namespace FitBuddy.WinForms.UI.Formularios
{
    public partial class GestionarPlanAlimenticio : MetroForm
    {
        private readonly IFormManager _formManager;

        public GestionarPlanAlimenticio(IFormManager formManager)
        {
            InitializeComponent();
            lblWelcome.Text = $"Usuario {IdentityManager.UsuarioActual.Username}";
            _formManager = formManager;
        }

        private void OnBtnCrearDietaClick(object sender, EventArgs e)
        {
            _formManager.Show<CrearDieta>();
        }

        private void OnBtnVerDietaClick(object sender, EventArgs e)
        {
            _formManager.Show<Dieta>();
        }

        private void OnBtnAtrasClick(object sender, EventArgs e)
        {
            _formManager.Close(this);
        }
    }
}
