using FitBuddy.Business.Facade;
using FitBuddy.Business.Modelos;
using FitBuddy.WinForms.UI.ExtensionMethods;
using FitBuddy.WinForms.UI.Formularios.Modelos;
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
        private List<ConsumoAlimentosModelo> _consumoAlimentos = new List<ConsumoAlimentosModelo>();
        private BindingSource _bindingSource;
        private IEnumerable<CargarAlimentoModelo> _tablaAlimentosCalorías;

        public CargarAlimento(IFormManager formManager, ICargarAlimentoBusinessLogic cargarAlimentoBusinessLogic)
        {
            InitializeComponent();
            lblWelcome.FormatearControl(IdentityManager.UsuarioActual.Username);
            _formManager = formManager;
            _cargarAlimentoBusinessLogic = cargarAlimentoBusinessLogic;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            ActualizarTotalCalorías();

            // Inicializar el auto complete.
            var autoCompleteStringCollection = new AutoCompleteStringCollection();
            _tablaAlimentosCalorías = _cargarAlimentoBusinessLogic.ObtenerAlimentosYCalorías();
            var listaDeAlimentos = _tablaAlimentosCalorías.Select(ac => ac.Alimento);
            autoCompleteStringCollection.AddRange(listaDeAlimentos.ToArray());
            txtComida.AutoCompleteCustomSource = autoCompleteStringCollection;

            // Asociar la fuente de datos del data grid a la lista de consumo de alimentos.
            _bindingSource = new BindingSource();
            _bindingSource.DataSource = _consumoAlimentos;
            datConsumoAlimentos.DataSource = _bindingSource;

            // Inicializar combobox con los momentos del día.
            var momentosDelDía = Recursos.Strings.CargarAlimento_MomentosDelDía.Split('|');
            cmbMomentoDelDía.Items.AddRange(momentosDelDía);
            cmbMomentoDelDía.SelectedIndex = 0;
        }

        private void OnBtnAgregarClick(object sender, EventArgs e)
        {
            if (!CamposSonVálidos())
                return;

            var consumo = new ConsumoAlimentosModelo
            {
                Comida = txtComida.Text,
                Porción = txtPorción.Text,
            };

            _consumoAlimentos.Add(consumo);
            _bindingSource.ResetBindings(false);

            ActualizarTotalCalorías();

            txtComida.Text = string.Empty;
            txtPorción.Text = string.Empty;
            txtComida.Focus();
        }

        private bool CamposSonVálidos()
        {
            if (!_tablaAlimentosCalorías.Select(ac => ac.Alimento).Contains(txtComida.Text, StringComparer.InvariantCultureIgnoreCase))
            {
                MessageBox.Show(string.Format(Recursos.Strings.CargarAlimento_ErrorAlimentoNoEsVálido, txtComida.Text));
                txtComida.Focus();
                return false;
            }

            if (!float.TryParse(txtPorción.Text, out _))
            {
                MessageBox.Show(Recursos.Strings.CargarAlimento_ErrorPorciónNoEsVálida);
                txtPorción.Focus();
                return false;
            }

            if (cmbMomentoDelDía.SelectedIndex == -1)
            {
                MessageBox.Show(Recursos.Strings.CargarAlimento_ErrorMomentoDelDíaNoEsVálido);
                cmbMomentoDelDía.Focus();
                return false;
            }

            return true;
        }

        private void ActualizarTotalCalorías()
        {
            var caloriasTotales = 0f;

            foreach (var alimento in _consumoAlimentos)
            {
                var alimentoCaloría = _tablaAlimentosCalorías.Single(ac => ac.Alimento.Equals(alimento.Comida, StringComparison.InvariantCultureIgnoreCase));
                caloriasTotales += float.Parse(alimento.Porción) * alimentoCaloría.CaloríasCadaCienGramos / 100;
            }

            lblCalorías.FormatearControl(caloriasTotales.ToString());
        }

        private void OnBtnAtrásClick(object sender, EventArgs e)
        {
            _formManager.Close(this);
        }

        private void OnTxtPorciónKeyPress(object sender, KeyPressEventArgs e)
        {
            var keyChar = e.KeyChar;
            if (!char.IsControl(keyChar) && !char.IsDigit(keyChar) && keyChar != '.' && keyChar != ',')
            {
                e.Handled = true;
            }

            if ((keyChar == '.' || keyChar == ',') && txtPorción.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }

            if (keyChar == ',' && txtPorción.Text.IndexOf('.') == -1)
            {
                e.Handled = true;
                txtPorción.Text += '.';
                txtPorción.SelectionStart = txtPorción.Text.Length;
            }
        }
    }
}
