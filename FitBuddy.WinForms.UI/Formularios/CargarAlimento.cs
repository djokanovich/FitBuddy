using FitBuddy.Business.Facade;
using FitBuddy.WinForms.UI.Security;
using MetroFramework.Forms;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FitBuddy.WinForms.UI.Formularios
{
    public partial class CargarAlimento : MetroForm
    {
        private readonly IFormManager _formManager;
        private readonly ICargarAlimentoBusinessLogic _cargarAlimentoBusinessLogic;

        public CargarAlimento(IFormManager formManager, ICargarAlimentoBusinessLogic cargarAlimentoBusinessLogic)
        {
            InitializeComponent();
            lblWelcome.Text = $"Usuario {IdentityManager.UsuarioActual.Username}";
            _formManager = formManager;
            _cargarAlimentoBusinessLogic = cargarAlimentoBusinessLogic;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            var autoCompleteStringCollection = new AutoCompleteStringCollection();

            var alimentos = _cargarAlimentoBusinessLogic.ObtenerAlimentos();
            autoCompleteStringCollection.AddRange(alimentos.ToArray());
            txtComida.AutoCompleteCustomSource = autoCompleteStringCollection;
        }

        private void OnBtnAtrasClick(object sender, EventArgs e)
        {
            _formManager.Close(this);
        }
    }
}
