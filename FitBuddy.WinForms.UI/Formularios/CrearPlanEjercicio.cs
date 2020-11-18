using FitBuddy.Business.Facade;
using FitBuddy.Entidades;
using FitBuddy.Entidades.Enums;
using FitBuddy.WinForms.UI.ExtensionMethods;
using FitBuddy.WinForms.UI.Security;
using MetroFramework.Forms;
using System;
using System.Windows.Forms;

namespace FitBuddy.WinForms.UI.Formularios
{
    public partial class CrearPlanEjercicio : MetroForm
    {
        private readonly ICrearPlanEjercicioBusinessLogic _crearPlanEjercicioBusinessLogic;

        public CrearPlanEjercicio(ICrearPlanEjercicioBusinessLogic crearPlanEjercicioBusinessLogic)
        {
            InitializeComponent();
            lblWelcome.FormatearControl(IdentityManager.UsuarioActual.Username);
            _crearPlanEjercicioBusinessLogic = crearPlanEjercicioBusinessLogic;
        }

        private void CrearPlanEjercicio_Load(object sender, EventArgs e)
        {
            cmbFrecuencia.Items.Add("Nunca"); //0
            cmbFrecuencia.Items.Add("Una vez por semana"); //1
            cmbFrecuencia.Items.Add("Dos veces por semana"); //2
            cmbFrecuencia.Items.Add("Más de tres veces por semana"); //3

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
            var usuarioId = IdentityManager.UsuarioActual.UserId;

            var paciente = new Paciente
            {
                FrecuenciaActual = (Frecuencia)cmbFrecuencia.SelectedIndex,
                DisposiciónDiariaHoras = (DisponibilidadHoras)cmbDisponibilidadHoras.SelectedIndex,
                DisposiciónSemanalDias = (Frecuencia)cmbDisponibilidadDias.SelectedIndex,
                Antecedentes = Antecedentes.None
            };

            if (chkArticulaciones.Checked) paciente.Antecedentes |= Antecedentes.ProblemasArticulatorios;
            if (chkArtrosis.Checked) paciente.Antecedentes |= Antecedentes.ArtrosisDolenciaCrónica;
            if (chkInfarto.Checked) paciente.Antecedentes |= Antecedentes.InfartoCardiopatía;
            if (chkEscoliosis.Checked) paciente.Antecedentes |= Antecedentes.Escoliosis;
            if (chkRodillas.Checked) paciente.Antecedentes |= Antecedentes.RoturaDeMeñiscosProblemaDeRodillas;
            if (chkRespiratorio.Checked) paciente.Antecedentes |= Antecedentes.EnfermedadRespiratoria;

            _crearPlanEjercicioBusinessLogic.GuardarPlanEjercicio(usuarioId, paciente);

            MessageBox.Show("Perfil de ejercicio cargado con éxito");
        }
    }
}
