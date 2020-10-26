using FitBuddy.Business.Facade;
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

            paciente.Alergias = Alimento.None;
            if (chkHuevo.Checked) paciente.Alergias |= Alimento.Huevo;
            if (chkLeche.Checked) paciente.Alergias |= Alimento.Lácteos;
            if (chkTomate.Checked) paciente.Alergias |= Alimento.Tomate;
            if (chkCarneVaca.Checked) paciente.Alergias |= Alimento.CarneDeVaca;
            if (chkCarneCerdo.Checked) paciente.Alergias |= Alimento.CarneDeCerdo;
            if (chkPescado.Checked) paciente.Alergias |= Alimento.Pescado;
            if (chkMariscos.Checked) paciente.Alergias |= Alimento.Mariscos;
            if (chkFrutosSecos.Checked) paciente.Alergias |= Alimento.FrutosSecos;
            if (chkQueso.Checked) paciente.Alergias |= Alimento.Queso;
            if (chkTrigo.Checked) paciente.Alergias |= Alimento.Tacc;
            if (chkFructosa.Checked) paciente.Alergias |= Alimento.Fructuosa;
            if (chkHojasVerdes.Checked) paciente.Alergias |= Alimento.HojasVerdes;
            if (chkFrutasRojas.Checked) paciente.Alergias |= Alimento.FrutosRojos;
            if (chkSoja.Checked) paciente.Alergias |= Alimento.Soja;

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
