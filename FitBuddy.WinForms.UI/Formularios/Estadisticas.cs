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
            _estadisticasBusinessLogic.CalcularEstadísticasDePacientePorUsuarioId(IdentityManager.UsuarioActual.UserId);
            
            lblImc.Text = _estadisticasBusinessLogic.Imc;
            lblIgc.Text = _estadisticasBusinessLogic.Igc;

            lblImcClasificación.Text = _estadisticasBusinessLogic.ImcClasificación;
            lblIgcClasificacion.Text = _estadisticasBusinessLogic.IgcClasificación;
        }
    }
}
