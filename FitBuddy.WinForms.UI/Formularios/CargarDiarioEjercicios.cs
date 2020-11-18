using FitBuddy.WinForms.UI.ExtensionMethods;
using FitBuddy.WinForms.UI.Security;
using MetroFramework.Forms;

namespace FitBuddy.WinForms.UI.Formularios
{
    public partial class CargarDiarioEjercicios : MetroForm
    {
        private readonly IFormManager _formManager;

        public CargarDiarioEjercicios(IFormManager formManager)
        {
            InitializeComponent();
            lblWelcome.FormatearControl(IdentityManager.UsuarioActual.Username);
            _formManager = formManager;
        }

        private void OnBtnAtrasClick(object sender, System.EventArgs e)
        {
            _formManager.Close(this);
        }
    }
}
