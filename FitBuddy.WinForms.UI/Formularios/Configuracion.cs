using FitBuddy.Business.Facade;
using FitBuddy.Entidades;
using FitBuddy.WinForms.UI.Security;
using MetroFramework.Forms;
using System;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace FitBuddy.WinForms.UI.Formularios
{
    public partial class Configuracion : MetroForm
    {
        private readonly IFormManager _formManager;
        private readonly IConfiguraciónBusinessLogic _configuraciónBusinessLogic;

        public Configuracion(IFormManager formManager, IConfiguraciónBusinessLogic configuraciónBusinessLogic)
        {
            InitializeComponent();
            _formManager = formManager;
            _configuraciónBusinessLogic = configuraciónBusinessLogic;
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            _formManager.Show<Configuracion>();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            var idiomas = _configuraciónBusinessLogic.ObtenerIdiomas();
            cmbIdioma.Items.AddRange(idiomas);
            cmbIdioma.ValueMember = "Id";
            cmbIdioma.DisplayMember = "Nombre";

            if (idiomas.Any())
                cmbIdioma.SelectedIndex = 0;
        }

        private void OnBtnGuardarClick(object sender, EventArgs e)
        {
            var usuarioId = IdentityManager.UsuarioActual.UserId;
            var idioma = (Idioma)cmbIdioma.SelectedItem;

            if (!_configuraciónBusinessLogic.ActualizarUsuarioIdioma(usuarioId, idioma))
            {
                MessageBox.Show("Error al intentar actualizar el idioma.");
                return;
            }

            var cultureInfo = new CultureInfo(idioma.Código);

            Thread.CurrentThread.CurrentCulture = cultureInfo;
            Thread.CurrentThread.CurrentUICulture = cultureInfo;

            CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
            CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;

            MessageBox.Show("Please restart the system");
            _formManager.Close(this);
        }
    }
}
