using BLL;
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
            ComboBox1.Text = null;
            ComboBox2.Text = null;
            
        }
        private void AgendarTurno_Load(object sender, EventArgs e)
        {
            var gesMedico = new gesMedico();
            var medicos = gesMedico.ObtenerMedicos();
            //ComboBox2.Items.AddRange(medicos.Select(m => m.Nombre).ToArray());
            ComboBox2.DataSource = medicos;
            ComboBox2.DisplayMember = "Nombre";
            ComboBox2.ValueMember = "Email";

            ComboBox1.Items.Add("9:00");
            ComboBox1.Items.Add("10:00");
            ComboBox1.Items.Add("11:00");
            ComboBox1.Items.Add("12:00");
            ComboBox1.Items.Add("13:00");
            ComboBox1.Items.Add("14:00");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Turno cargado con éxito, un administrador se pondrá en contacto para coordinar tu cita.");
            Clear();
        }
    }
}
