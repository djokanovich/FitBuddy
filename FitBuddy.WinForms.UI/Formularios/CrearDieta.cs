using FitBuddy.Business.Facade;
using FitBuddy.WinForms.UI.Security;
using System;
using System.Windows.Forms;

namespace FitBuddy.WinForms.UI.Formularios
{
    public partial class CrearDieta : Form
    {
        private readonly IFormManager _formManager;
        private readonly ICrearDietaBusinessLogic _crearDietaBusinessLogic;

        public CrearDieta(IFormManager formManager, ICrearDietaBusinessLogic crearDietaBusinessLogic)
        {
            InitializeComponent();
            lblWelcome.Text = $"Usuario {IdentityManager.UsuarioActual.Username}";
            _formManager = formManager;
            _crearDietaBusinessLogic = crearDietaBusinessLogic;
        }

        private void OnBtnEnviarClick(object sender, EventArgs e)
        {
            var paciente = _crearDietaBusinessLogic.ObtenerOCrearPacientePorUsuarioId(IdentityManager.UsuarioActual.UserId);

            paciente.Huevo = chkHuevo.Checked;
            paciente.Leche = chkLeche.Checked;
            paciente.Tomate = chkTomate.Checked;
            paciente.Vaca = chkCarneVaca.Checked;
            paciente.Cerdo = chkCarneCerdo.Checked;
            paciente.Pescado = chkPescado.Checked;
            paciente.Mariscos = chkMariscos.Checked;
            paciente.FrutosSecos = chkFrutosSecos.Checked;
            paciente.Queso = chkQueso.Checked;
            paciente.Tacc = chkTrigo.Checked;
            paciente.Fructuosa = chkFructosa.Checked;
            paciente.HojasVerdes = chkHojasVerdes.Checked;
            paciente.FrutasRojas = chkFrutasRojas.Checked;
            paciente.Soja = chkSoja.Checked;

            _crearDietaBusinessLogic.ActualizarPaciente(paciente.Id);

            MessageBox.Show("Perfil alimenticio cargado con éxito");
            _formManager.Close(this);
        }

        private void OnBtnAtrasClick(object sender, EventArgs e)
        {
            _formManager.Close(this);
        }
    }
}
