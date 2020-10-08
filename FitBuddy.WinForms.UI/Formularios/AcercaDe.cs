using System;
using System.Windows.Forms;

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
            _formManager.Show<LogIn>();
        }
    }
}
