using FitBuddy.WinForms.UI.Security;
using System.Windows.Forms;

namespace FitBuddy.WinForms.UI.Formularios
{
    public partial class CargarDiarioEjercicios : Form
    {
        public CargarDiarioEjercicios()
        {
            InitializeComponent();
            lblWelcome.Text = $"Usuario {IdentityManager.UsuarioActual.Username}";
        }
    }
}
