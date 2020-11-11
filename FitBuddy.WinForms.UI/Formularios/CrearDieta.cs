using FitBuddy.Business.Facade;
using FitBuddy.Entidades;
using FitBuddy.Entidades.Enums;
using FitBuddy.WinForms.UI.Security;
using MetroFramework.Forms;
using System;
using System.Windows.Forms;

namespace FitBuddy.WinForms.UI.Formularios
{
    public partial class CrearDieta : MetroForm
    {
        private readonly IFormManager _formManager;
        private readonly ICrearDietaBusinessLogic _crearDietaBusinessLogic;
        private Paciente _paciente;

        private readonly Tuple<CheckBox, Alimento>[] _checkBoxesAlimentos;

        public CrearDieta(IFormManager formManager, ICrearDietaBusinessLogic crearDietaBusinessLogic)
        {
            InitializeComponent();
            lblWelcome.Text = $"Usuario {IdentityManager.UsuarioActual.Username}";
            _formManager = formManager;
            _crearDietaBusinessLogic = crearDietaBusinessLogic;

            _checkBoxesAlimentos = new Tuple<CheckBox, Alimento>[]
            {
                new Tuple<CheckBox, Alimento>(chkHuevo, Alimento.Huevo),
                new Tuple<CheckBox, Alimento>(chkLeche, Alimento.Lácteos),
                new Tuple<CheckBox, Alimento>(chkTomate, Alimento.Tomate),
                new Tuple<CheckBox, Alimento>(chkCarneVaca, Alimento.CarneDeVaca),
                new Tuple<CheckBox, Alimento>(chkCarneCerdo, Alimento.CarneDeCerdo),
                new Tuple<CheckBox, Alimento>(chkPescado, Alimento.Pescado),
                new Tuple<CheckBox, Alimento>(chkMariscos, Alimento.Mariscos),
                new Tuple<CheckBox, Alimento>(chkFrutosSecos, Alimento.FrutosSecos),
                new Tuple<CheckBox, Alimento>(chkQueso, Alimento.Queso),
                new Tuple<CheckBox, Alimento>(chkTrigo, Alimento.Tacc),
                new Tuple<CheckBox, Alimento>(chkFructosa, Alimento.Fructuosa),
                new Tuple<CheckBox, Alimento>(chkHojasVerdes, Alimento.HojasVerdes),
                new Tuple<CheckBox, Alimento>(chkFrutasRojas, Alimento.FrutosRojos),
                new Tuple<CheckBox, Alimento>(chkSoja, Alimento.Soja),
            };
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            var usuarioId = IdentityManager.UsuarioActual.UserId;
            _paciente = _crearDietaBusinessLogic.ObtenerPacienteAsociadoAUsuario(usuarioId);
            if (_paciente == null)
                return;

            foreach (var checkBoxAlimento in _checkBoxesAlimentos)
            {
                checkBoxAlimento.Item1.Checked = _paciente.EsAlérgicoA(checkBoxAlimento.Item2);
            }
        }

        private void OnBtnEnviarClick(object sender, EventArgs e)
        {
            var usuarioId = IdentityManager.UsuarioActual.UserId;
            
            if (_paciente == null)
                _paciente = new Paciente();

            foreach (var checkBoxAlimento in _checkBoxesAlimentos)
            {
                if (checkBoxAlimento.Item1.Checked)
                    _paciente.AgregarAlergiaA(checkBoxAlimento.Item2);
                else
                    _paciente.QuitarAlergiaA(checkBoxAlimento.Item2);
            }

            var éxito = _crearDietaBusinessLogic.CrearOActualizarPacienteAsociadoAUsuario(usuarioId, _paciente);

            if (éxito)
                MessageBox.Show("Perfil alimenticio cargado con éxito.");
            else
                MessageBox.Show("No se ha podido guardar los cambios. Si el problema persiste, notifique a un administrador.");

            _formManager.Close(this);
        }

        private void OnBtnAtrasClick(object sender, EventArgs e)
        {
            _formManager.Close(this);
        }
    }
}
