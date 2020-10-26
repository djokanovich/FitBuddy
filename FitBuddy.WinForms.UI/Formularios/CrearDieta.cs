using FitBuddy.Business.Facade;
using FitBuddy.Entidades;
using FitBuddy.Entidades.Enums;
using FitBuddy.WinForms.UI.Security;
using System;
using System.Windows.Forms;

namespace FitBuddy.WinForms.UI.Formularios
{
    public partial class CrearDieta : Form
    {
        private readonly IFormManager _formManager;
        private readonly ICrearDietaBusinessLogic _crearDietaBusinessLogic;
        private Paciente _paciente;

        public CrearDieta(IFormManager formManager, ICrearDietaBusinessLogic crearDietaBusinessLogic)
        {
            InitializeComponent();
            lblWelcome.Text = $"Usuario {IdentityManager.UsuarioActual.Username}";
            _formManager = formManager;
            _crearDietaBusinessLogic = crearDietaBusinessLogic;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            var usuarioId = IdentityManager.UsuarioActual.UserId;
            _paciente = _crearDietaBusinessLogic.ObtenerPacienteAsociadoAUsuario(usuarioId);
            if (_paciente == null) return;

            chkHuevo.Checked = _paciente.EsAlérgicoA(Alimento.Huevo);
            chkLeche.Checked = _paciente.EsAlérgicoA(Alimento.Lácteos);
            chkTomate.Checked = _paciente.EsAlérgicoA(Alimento.Tomate);
            chkCarneVaca.Checked = _paciente.EsAlérgicoA(Alimento.CarneDeVaca);
            chkCarneCerdo.Checked = _paciente.EsAlérgicoA(Alimento.CarneDeCerdo);
            chkPescado.Checked = _paciente.EsAlérgicoA(Alimento.Pescado);
            chkMariscos.Checked = _paciente.EsAlérgicoA(Alimento.Mariscos);
            chkFrutosSecos.Checked = _paciente.EsAlérgicoA(Alimento.FrutosSecos);
            chkQueso.Checked = _paciente.EsAlérgicoA(Alimento.Queso);
            chkTrigo.Checked = _paciente.EsAlérgicoA(Alimento.Tacc);
            chkFructosa.Checked = _paciente.EsAlérgicoA(Alimento.Fructuosa);
            chkHojasVerdes.Checked = _paciente.EsAlérgicoA(Alimento.HojasVerdes);
            chkFrutasRojas.Checked = _paciente.EsAlérgicoA(Alimento.FrutosRojos);
            chkSoja.Checked = _paciente.EsAlérgicoA(Alimento.Soja);
        }

        private void OnBtnEnviarClick(object sender, EventArgs e)
        {
            var usuarioId = IdentityManager.UsuarioActual.UserId;
            if (_paciente == null) _paciente = new Paciente();

            if (chkHuevo.Checked) _paciente.AgregarAlergiaA(Alimento.Huevo);
            if (chkLeche.Checked) _paciente.AgregarAlergiaA(Alimento.Lácteos);
            if (chkTomate.Checked) _paciente.AgregarAlergiaA(Alimento.Tomate);
            if (chkCarneVaca.Checked) _paciente.AgregarAlergiaA(Alimento.CarneDeVaca);
            if (chkCarneCerdo.Checked) _paciente.AgregarAlergiaA(Alimento.CarneDeCerdo);
            if (chkPescado.Checked) _paciente.AgregarAlergiaA(Alimento.Pescado);
            if (chkMariscos.Checked) _paciente.AgregarAlergiaA(Alimento.Mariscos);
            if (chkFrutosSecos.Checked) _paciente.AgregarAlergiaA(Alimento.FrutosSecos);
            if (chkQueso.Checked) _paciente.AgregarAlergiaA(Alimento.Queso);
            if (chkTrigo.Checked) _paciente.AgregarAlergiaA(Alimento.Tacc);
            if (chkFructosa.Checked) _paciente.AgregarAlergiaA(Alimento.Fructuosa);
            if (chkHojasVerdes.Checked) _paciente.AgregarAlergiaA(Alimento.HojasVerdes);
            if (chkFrutasRojas.Checked) _paciente.AgregarAlergiaA(Alimento.FrutosRojos);
            if (chkSoja.Checked) _paciente.AgregarAlergiaA(Alimento.Soja);

            var éxito = _crearDietaBusinessLogic.CrearOActualizarPaciente(usuarioId, _paciente);

            if (éxito)
            {
                MessageBox.Show("Perfil alimenticio cargado con éxito.");
            } // TODO: else?

            _formManager.Close(this);
        }

        private void OnBtnAtrasClick(object sender, EventArgs e)
        {
            _formManager.Close(this);
        }
    }
}
