using BLL;
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
    public partial class AgendarTurno : Form
    {
        public AgendarTurno()
        {
            InitializeComponent();
            var customPrincipal = Thread.CurrentPrincipal as CustomPrincipal;
            lblWelcome.Text = $"Usuario {customPrincipal.Identity.Name}";
        }

        public void Clear()
        {
            cmbFranjaHoraria.Text = null;
            cmbMedico.Text = null;
            
        }
        private void AgendarTurno_Load(object sender, EventArgs e)
        {
            var gesMedico = new gesMedico();
            var medicos = gesMedico.ObtenerMedicos();
            //ComboBox2.Items.AddRange(medicos.Select(m => m.Nombre).ToArray());
            cmbMedico.DataSource = medicos;
            cmbMedico.DisplayMember = "Nombre";
            cmbMedico.ValueMember = "Email";

            cmbFranjaHoraria.Items.Add("9:00");
            cmbFranjaHoraria.Items.Add("10:00");
            cmbFranjaHoraria.Items.Add("11:00");
            cmbFranjaHoraria.Items.Add("12:00");
            cmbFranjaHoraria.Items.Add("13:00");
            cmbFranjaHoraria.Items.Add("14:00");
        }

        private void OnBtnEnviarClick(object sender, EventArgs e)
        {
            MessageBox.Show("Turno cargado con éxito, un administrador se pondrá en contacto para coordinar tu cita.");
            Clear();
        }
    }
}
