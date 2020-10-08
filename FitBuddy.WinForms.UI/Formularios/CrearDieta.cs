using FitBuddy.Business;
using FitBuddy.WinForms.UI.Security;
using System;
using System.Threading;
using System.Windows.Forms;

namespace FitBuddy.WinForms.UI.Formularios
{
    public partial class CrearDieta : Form
    {
        private readonly gesPaciente _gesPaciente;
        private CustomPrincipal _customPrincipal;

        public CrearDieta(gesPaciente gesPaciente)
        {
            InitializeComponent();
            _customPrincipal = Thread.CurrentPrincipal as CustomPrincipal;
            lblWelcome.Text = $"Usuario {_customPrincipal.Identity.Name}";
            _gesPaciente = gesPaciente;
        }

        private void OnBtnEnviarClick(object sender, EventArgs e)
        {
            var paciente = _gesPaciente.ObtenerPaciente(_customPrincipal.Identity.Id);

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

            _gesPaciente.ActualizarPaciente(paciente);

            MessageBox.Show("Perfil alimenticio cargado con éxito");
        }
    }
}
