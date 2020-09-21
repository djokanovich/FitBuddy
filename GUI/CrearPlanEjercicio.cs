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

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void CheckBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void CrearPlanEjercicio_Load(object sender, EventArgs e)
        {
            ComboBox1.Items.Add("Nunca");
            ComboBox1.Items.Add("Una vez por semana");
            ComboBox1.Items.Add("Dos veces por semana");
            ComboBox1.Items.Add("Más de tres veces por semana");

            ComboBox2.Items.Add("Ganar peso");
            ComboBox2.Items.Add("Perder peso");
            ComboBox2.Items.Add("Ganar masa muscular");
            ComboBox2.Items.Add("Estar más saludable");

            ComboBox3.Items.Add("Nunca");
            ComboBox3.Items.Add("Una vez por semana");
            ComboBox3.Items.Add("Dos veces por semana");
            ComboBox3.Items.Add("Más de tres veces por semana");

            ComboBox4.Items.Add("Menos de una hora");
            ComboBox4.Items.Add("Entre una y dos horas");
            ComboBox4.Items.Add("Más de dos horas");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Perfil de ejercicio cargado con éxito");
        }
    }
}
