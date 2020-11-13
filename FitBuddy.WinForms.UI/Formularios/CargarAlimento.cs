using FitBuddy.Business.Facade;
using FitBuddy.Business.Modelos;
using FitBuddy.WinForms.UI.Security;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FitBuddy.WinForms.UI.Formularios
{
    public partial class CargarAlimento : MetroForm
    {
        private readonly IFormManager _formManager;
        private readonly ICargarAlimentoBusinessLogic _cargarAlimentoBusinessLogic;
        private List<ConsumoAlimentosData> _consumoAlimentos = new List<ConsumoAlimentosData>();
        private BindingSource _bindingSource;
        private IEnumerable<CargarAlimentoModelo> _alimentosYCalorías;

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

            _alimentosYCalorías = _cargarAlimentoBusinessLogic.ObtenerAlimentosYCalorías().ToList();
            autoCompleteStringCollection.AddRange(_alimentosYCalorías.Select(ac => ac.Comida).ToArray());
            txtComida.AutoCompleteCustomSource = autoCompleteStringCollection;

            _bindingSource = new BindingSource();
            _bindingSource.DataSource = _consumoAlimentos;
            datConsumoAlimentos.DataSource = _bindingSource;
            cmbMomento.Items.Add("Desayuno");
            cmbMomento.Items.Add("Almuerzo");
            cmbMomento.Items.Add("Merienda");
            cmbMomento.Items.Add("Cena");
            cmbMomento.Items.Add("Colación");
        }

        private void OnBtnAtrasClick(object sender, EventArgs e)
        {
            _formManager.Close(this);
        }

        private void CargarAlimento_Load(object sender, EventArgs e)
        {
            
        }

        private void cmbPorcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            var consumo = new ConsumoAlimentosData
            {
                Comida = txtComida.Text,
                Porción = txtPorcion.Text,
            };
            _consumoAlimentos.Add(consumo);

            _bindingSource.ResetBindings(false);

            var caloriasTotales = 0f;

            foreach (var alimento in _consumoAlimentos)
            {
                var alimentoCaloria = _alimentosYCalorías.Single(ac => ac.Comida == alimento.Comida);
                caloriasTotales += float.Parse(alimento.Porción) * alimentoCaloria.CaloríasCadaCienGramos / 100; 
            }

            lblCalorias.Text = caloriasTotales.ToString();


        }
    }
}
