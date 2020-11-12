using FitBuddy.Business.Facade;
using FitBuddy.WinForms.UI.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitBuddy.WinForms.UI.Formularios
{
    public partial class EstadisticasCompletas : Form
    {
        private readonly IEstadisticasCompletasBusinessLogic _estadisticasCompletasBusinessLogic;

        public EstadisticasCompletas(IEstadisticasCompletasBusinessLogic estadisticasCompletasBusinessLogic)
        {
            InitializeComponent();
            _estadisticasCompletasBusinessLogic = estadisticasCompletasBusinessLogic;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            var usuarioId = IdentityManager.UsuarioActual.UserId;

            chartPeso.DataSource = _estadisticasCompletasBusinessLogic.ObtenerHistorialPesos(usuarioId);
            chartPeso.SeriesTemplate.SeriesDataMember = "Fecha";
            chartPeso.SeriesTemplate.ArgumentDataMember = "Peso";
        }
    }
}
