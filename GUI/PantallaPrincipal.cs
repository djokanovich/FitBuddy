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
    public partial class PantallaPrincipal : Form
    {
        public PantallaPrincipal()
        {
            InitializeComponent();
            var customPrincipal = Thread.CurrentPrincipal as CustomPrincipal;
            lblWelcome.Text = $"Bienvenido, {customPrincipal.Identity.Name}";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var gesPerfil = new GestionarPerfil();
            gesPerfil.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var gesPlanAlim = new GestionarPlanAlimenticio();
            gesPlanAlim.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            var gesPlanEj = new GestionarPlanEjercicios();
            gesPlanEj.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            var cargaComidas = new CargarAlimento();
            cargaComidas.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            var cargaEjercicio = new CargarDiarioEjercicios();
            cargaEjercicio.Show();
            
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sección en construcción");
            return;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sección en construcción");
            return;
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sección en construcción");
            return;
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            var AgendaTurno = new AgendarTurno();
            AgendaTurno.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var backup = new Backup();
            backup.Show();
        }
    }
}
