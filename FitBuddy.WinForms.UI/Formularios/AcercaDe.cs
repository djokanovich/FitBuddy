using System;
using System.Windows.Forms;
using FitBuddy.WinForms.UI.Security;

namespace FitBuddy.WinForms.UI.Formularios
{
    public partial class AcercaDe : Form
    {
        private readonly IFormManager _formManager;

        public AcercaDe(IFormManager formManager)
        {
            InitializeComponent();
            _formManager = formManager;
        }

        private void OnBtnAceptarClick(object sender, EventArgs e)
        {
            if (IdentityManager.HayUsuarioLogueado())
            {
                _formManager.Show<PantallaPrincipal>();
            }
            else
            {
                _formManager.Show<LogIn>();
            }
        }
    }
}
