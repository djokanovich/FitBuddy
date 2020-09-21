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
    public partial class GestionarPlanAlimenticio : Form
    {
        public GestionarPlanAlimenticio()
        {
            InitializeComponent();
            var customPrincipal = Thread.CurrentPrincipal as CustomPrincipal;
            lblWelcome.Text = $"Usuario {customPrincipal.Identity.Name}";
        }

        private void GestionarPlanAlimenticio_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var crearDieta = new CrearDieta();
            crearDieta.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sección en construcción");
        }
    }
}
