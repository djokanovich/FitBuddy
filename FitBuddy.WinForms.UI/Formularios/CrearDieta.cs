using FitBuddy.Business;
using FitBuddy.WinForms.UI.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitBuddy.WinForms.UI.Formularios
{
    public partial class CrearDieta : Form
    {
        private CustomPrincipal _customPrincipal;

        public CrearDieta()
        {
            InitializeComponent();
            _customPrincipal = Thread.CurrentPrincipal as CustomPrincipal;
            lblWelcome.Text = $"Usuario {_customPrincipal.Identity.Name}";
        }

        private void OnBtnEnviarClick(object sender, EventArgs e)
        {
            gesPaciente gesPaciente = new gesPaciente();
            var paciente = gesPaciente.ObtenerPaciente(_customPrincipal.Identity.Id);

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

            gesPaciente.ActualizarPaciente(paciente);

            MessageBox.Show("Perfil alimenticio cargado con éxito");
        }
    }
}
