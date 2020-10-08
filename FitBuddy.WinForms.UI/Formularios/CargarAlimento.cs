using FitBuddy.WinForms.UI.Security;
using System.Windows.Forms;

namespace FitBuddy.WinForms.UI.Formularios
{
    public partial class CargarAlimento : Form
    {
        public CargarAlimento()
        {
            InitializeComponent();
            lblWelcome.Text = $"Usuario {IdentityManager.UsuarioActual.Username}";
        }

        private void CargarAlimento_Load(object sender, System.EventArgs e)
        {

        }
    }
}
