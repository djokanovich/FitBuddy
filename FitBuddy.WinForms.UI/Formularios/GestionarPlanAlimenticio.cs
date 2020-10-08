using FitBuddy.WinForms.UI.Security;
using System;
using System.Windows.Forms;

namespace FitBuddy.WinForms.UI.Formularios
{
    public partial class GestionarPlanAlimenticio : Form
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
            MessageBox.Show("Sección en construcción");
        }

        private void OnBtnAtrasClick(object sender, EventArgs e)
        {
            _formManager.Close(this);
        }
    }
}
