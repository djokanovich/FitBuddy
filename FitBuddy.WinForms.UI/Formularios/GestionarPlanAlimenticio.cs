using FitBuddy.WinForms.UI.Security;
using System;
using System.Windows.Forms;

namespace FitBuddy.WinForms.UI.Formularios
{
    public partial class GestionarPlanAlimenticio : Form
    {
        private readonly IFormManager _formBuilder;

        public GestionarPlanAlimenticio(IFormManager formBuilder)
        {
            InitializeComponent();
            lblWelcome.Text = $"Usuario {IdentityManager.UsuarioActual.Username}";
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

        private void OnBtnAtrasClick(object sender, EventArgs e)
        {
            _formBuilder.Close(this);
        }
    }
}
