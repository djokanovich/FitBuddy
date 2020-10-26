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
    public partial class Dieta : Form
    {
        private readonly IDietaBusinessLogic _dietaBusinessLogic;

        public Dieta(IDietaBusinessLogic dietaBusinessLogic)
        {
            InitializeComponent();
            _dietaBusinessLogic = dietaBusinessLogic;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            desayunoLunes.Text = _dietaBusinessLogic.ElegirAlimentoAlAzar(IdentityManager.UsuarioActual.UserId);
            almuerzoLunes.Text = _dietaBusinessLogic.ElegirAlimentoAlAzar(IdentityManager.UsuarioActual.UserId);
            meriendaLunes.Text = _dietaBusinessLogic.ElegirAlimentoAlAzar(IdentityManager.UsuarioActual.UserId);
            cenaLunes.Text = _dietaBusinessLogic.ElegirAlimentoAlAzar(IdentityManager.UsuarioActual.UserId);

        }
    }
}
