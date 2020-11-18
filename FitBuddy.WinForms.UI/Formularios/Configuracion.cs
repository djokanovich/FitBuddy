using MetroFramework.Forms;
using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace FitBuddy.WinForms.UI.Formularios
{
    public partial class Configuracion : MetroForm
    {
        private readonly IFormManager _formManager;

        public Configuracion(IFormManager formManager)
        {
            InitializeComponent();
            _formManager = formManager;
        }

        
        private void btnBackup_Click(object sender, EventArgs e)
        {
            _formManager.Show<Configuracion>();
        }

        private void Configuracion_Load(object sender, EventArgs e)
        {
            cmbIdioma.Items.Add("Español");
            cmbIdioma.Items.Add("English");
        }

        private void OnBtnGuardarClick(object sender, EventArgs e)
        {
            var cultureInfo = new CultureInfo("es-AR");

            if (cmbIdioma.SelectedIndex == 1)
            {
                cultureInfo = new CultureInfo("en-US");
            }

            Thread.CurrentThread.CurrentCulture = cultureInfo;
            Thread.CurrentThread.CurrentUICulture = cultureInfo;

            CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
            CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;

            MessageBox.Show("Please restart the system");
            _formManager.Close(this);
        }
    }
}
