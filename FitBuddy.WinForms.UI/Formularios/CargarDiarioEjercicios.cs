using FitBuddy.WinForms.UI.Security;
using System.Windows.Forms;

namespace FitBuddy.WinForms.UI.Formularios
{
    public partial class CargarDiarioEjercicios : Form
    {
        private readonly IFormManager _formManager;

        public CargarDiarioEjercicios(IFormManager formManager)
        {
            InitializeComponent();
            lblWelcome.Text = $"Usuario {IdentityManager.UsuarioActual.Username}";
            _formManager = formManager;
        }

        private void OnBtnAtrasClick(object sender, System.EventArgs e)
        {
            _formManager.Close(this);
        }
    }
}
