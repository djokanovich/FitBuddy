using FitBuddy.Business.Facade;
using FitBuddy.WinForms.UI.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitBuddy.WinForms.UI.Formularios
{
    public partial class Estadisticas : Form
    {
        private readonly IEstadisticasBusinessLogic _estadisticasBusinessLogic;

        public Estadisticas(IEstadisticasBusinessLogic estadisticasBusinessLogic)
        {
            InitializeComponent();
            lblWelcome.Text = $"Usuario {IdentityManager.UsuarioActual.Username}";
            _estadisticasBusinessLogic = estadisticasBusinessLogic;
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Estadisticas_Load(object sender, EventArgs e)
        {
            (lblIMC.Text, lblIGC.Text) = _estadisticasBusinessLogic.CalcularIndices(IdentityManager.UsuarioActual.UserId);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
