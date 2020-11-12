using System;
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

            // TODO
        }
    }
}
