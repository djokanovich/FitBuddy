using FitBuddy.Business.Facade;
using FitBuddy.WinForms.UI.Security;
using System;
using System.Windows.Forms;

namespace FitBuddy.WinForms.UI.Formularios
{
    public partial class Estadísticas : Form
    {
        private readonly IEstadisticasBusinessLogic _estadisticasBusinessLogic;

        public Estadísticas(IEstadisticasBusinessLogic estadisticasBusinessLogic)
        {
            InitializeComponent();
            lblWelcome.Text = $"{IdentityManager.UsuarioActual.Username}";
            _estadisticasBusinessLogic = estadisticasBusinessLogic;
        }

        private void Estadisticas_Load(object sender, EventArgs e)
        {
            (lblImc.Text, lblIgc.Text) = _estadisticasBusinessLogic.CalcularIndices(IdentityManager.UsuarioActual.UserId);
        }
    }
}
