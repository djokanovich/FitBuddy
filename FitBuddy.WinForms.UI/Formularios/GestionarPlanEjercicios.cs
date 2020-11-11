using FitBuddy.WinForms.UI.Security;
using MetroFramework.Forms;
using System;
using System.Windows.Forms;

namespace FitBuddy.WinForms.UI.Formularios
{
    public partial class GestionarPlanEjercicios : MetroForm
    {
        private readonly IFormManager _formManager;

        public GestionarPlanEjercicios(IFormManager formManager)
        {
            InitializeComponent();
            lblWelcome.Text = $"Usuario {IdentityManager.UsuarioActual.Username}";
            _formManager = formManager;
        }

        private void OnBtnCrearPlanClick(object sender, EventArgs e)
        {
            _formManager.Show<CrearPlanEjercicio>();
        }

        private void OnBtnVerPlanClick(object sender, EventArgs e)
        {
            MessageBox.Show("Sección en construcción");
        }

        private void OnBtnAtrasClick(object sender, EventArgs e)
        {
            _formManager.Close(this);
        }
    }
}
