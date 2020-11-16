using System;
using System.Windows.Forms;
using Common.Bitacora;
using FitBuddy.WinForms.UI.Security;
using MetroFramework.Forms;

namespace FitBuddy.WinForms.UI.Formularios
{
    public partial class AcercaDe : MetroForm
    {
        private readonly IFormManager _formManager;
        private readonly IBitacora<AcercaDe> _bitacora;

        public AcercaDe(IFormManager formManager, IBitacora<AcercaDe> bitacora)
        {
            InitializeComponent();
            _formManager = formManager;
            _bitacora = bitacora;
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

        protected override void OnClosed(EventArgs e)
        {
            _bitacora.Info("Aplicación finalizada.");
            base.OnClosed(e);
        }

        private void OnAcercaDeKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                _formManager.Close(this);
            }
        }

        private void AcercaDe_Load(object sender, EventArgs e)
        {

        }
    }
}
