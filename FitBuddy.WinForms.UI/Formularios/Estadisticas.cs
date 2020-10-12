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
            switch (double.Parse(lblImc.Text))
            {
                case var bmi when bmi <= 18.5:
                    lblImcClasificación.Text = "Por debajo del peso apropiado.";
                    break;
                
                case var bmi when bmi <= 25.0:
                    lblImcClasificación.Text = "Dentro de los rangos normales.";
                    break;

                case var bmi when bmi <= 30.0:
                    lblImcClasificación.Text = "Con sobrepeso.";
                    break;

                default:
                    lblImcClasificación.Text = "Obeso.";
                    break;
            }
        }
    }
}
