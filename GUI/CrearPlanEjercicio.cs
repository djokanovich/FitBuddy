using GUI.Security;
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

namespace GUI
{
    public partial class CrearPlanEjercicio : Form
    {
        public CrearPlanEjercicio()
        {
            InitializeComponent();
            var customPrincipal = Thread.CurrentPrincipal as CustomPrincipal;
            lblWelcome.Text = $"Usuario {customPrincipal.Identity.Name}";
        }

        private void CrearPlanEjercicio_Load(object sender, EventArgs e)
        {
            cmbFrecuencia.Items.Add("Nunca");
            cmbFrecuencia.Items.Add("Una vez por semana");
            cmbFrecuencia.Items.Add("Dos veces por semana");
            cmbFrecuencia.Items.Add("Más de tres veces por semana");

            cmbObjetivo.Items.Add("Ganar peso");
            cmbObjetivo.Items.Add("Perder peso");
            cmbObjetivo.Items.Add("Ganar masa muscular");
            cmbObjetivo.Items.Add("Estar más saludable");

            cmbDisponibilidadDias.Items.Add("Nunca");
            cmbDisponibilidadDias.Items.Add("Una vez por semana");
            cmbDisponibilidadDias.Items.Add("Dos veces por semana");
            cmbDisponibilidadDias.Items.Add("Más de tres veces por semana");

            cmbDisponibilidadHoras.Items.Add("Menos de una hora");
            cmbDisponibilidadHoras.Items.Add("Entre una y dos horas");
            cmbDisponibilidadHoras.Items.Add("Más de dos horas");
        }

        private void OnBtnEnviarClick(object sender, EventArgs e)
        {
            MessageBox.Show("Perfil de ejercicio cargado con éxito");
        }
    }
}
