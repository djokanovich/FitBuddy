using System;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;
using FitBuddy.Business.Facade;
using FitBuddy.WinForms.UI.Security;
using MetroFramework.Forms;

namespace FitBuddy.WinForms.UI.Formularios
{
    public partial class EstadísticasCompletas : MetroForm
    {
        private readonly IEstadisticasCompletasBusinessLogic _estadisticasCompletasBusinessLogic;

        public EstadísticasCompletas(IEstadisticasCompletasBusinessLogic estadisticasCompletasBusinessLogic)
        {
            InitializeComponent();
            _estadisticasCompletasBusinessLogic = estadisticasCompletasBusinessLogic;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            var usuarioId = IdentityManager.UsuarioActual.UserId;

            chartPeso.Series.Clear();
            var series = new Series
            {
                Name = "Series",
                Color = Color.Blue,
                IsVisibleInLegend = false,
                ChartType = SeriesChartType.Line,
            };

            chartPeso.Series.Add(series);
            
            chartPeso.DataSource = _estadisticasCompletasBusinessLogic.ObtenerHistorialPesos(usuarioId);
            chartPeso.Series["Series"].XValueMember = "Fecha";
            chartPeso.Series["Series"].YValueMembers = "Peso";
        }
    }
}
