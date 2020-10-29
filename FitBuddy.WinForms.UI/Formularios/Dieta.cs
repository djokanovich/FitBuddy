using FitBuddy.Business.Facade;
using FitBuddy.Entidades.Enums;
using FitBuddy.WinForms.UI.Security;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace FitBuddy.WinForms.UI.Formularios
{
    public partial class Dieta : Form
    {
        private readonly IDietaBusinessLogic _dietaBusinessLogic;
        private PrintDocument _printDocument;
        private Bitmap _memoryImage;

        public Dieta(IDietaBusinessLogic dietaBusinessLogic)
        {
            InitializeComponent();
            _dietaBusinessLogic = dietaBusinessLogic;

            _printDocument = new PrintDocument();
            _printDocument.PrintPage += OnPrintPage;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            //lunes
            desayunoLunes.Text = _dietaBusinessLogic.ElegirAlimentoAlAzar(IdentityManager.UsuarioActual.UserId, TipoComida.Desayuno);
            almuerzoLunes.Text = _dietaBusinessLogic.ElegirAlimentoAlAzar(IdentityManager.UsuarioActual.UserId, TipoComida.Almuerzo);
            meriendaLunes.Text = _dietaBusinessLogic.ElegirAlimentoAlAzar(IdentityManager.UsuarioActual.UserId, TipoComida.Merienda);
            cenaLunes.Text = _dietaBusinessLogic.ElegirAlimentoAlAzar(IdentityManager.UsuarioActual.UserId, TipoComida.Cena);

            //martes
            dMartes.Text = _dietaBusinessLogic.ElegirAlimentoAlAzar(IdentityManager.UsuarioActual.UserId, TipoComida.Desayuno);
            aMartes.Text = _dietaBusinessLogic.ElegirAlimentoAlAzar(IdentityManager.UsuarioActual.UserId, TipoComida.Almuerzo);
            mMartes.Text = _dietaBusinessLogic.ElegirAlimentoAlAzar(IdentityManager.UsuarioActual.UserId, TipoComida.Merienda);
            cMartes.Text = _dietaBusinessLogic.ElegirAlimentoAlAzar(IdentityManager.UsuarioActual.UserId, TipoComida.Cena);

            //miercoles
            dMiercoles.Text = _dietaBusinessLogic.ElegirAlimentoAlAzar(IdentityManager.UsuarioActual.UserId, TipoComida.Desayuno);
            aMiercoles.Text = _dietaBusinessLogic.ElegirAlimentoAlAzar(IdentityManager.UsuarioActual.UserId, TipoComida.Almuerzo);
            mMiercoles.Text = _dietaBusinessLogic.ElegirAlimentoAlAzar(IdentityManager.UsuarioActual.UserId, TipoComida.Merienda);
            cMiercoles.Text = _dietaBusinessLogic.ElegirAlimentoAlAzar(IdentityManager.UsuarioActual.UserId, TipoComida.Cena);


            //jueves
            dJueves.Text = _dietaBusinessLogic.ElegirAlimentoAlAzar(IdentityManager.UsuarioActual.UserId, TipoComida.Desayuno);
            aJueves.Text = _dietaBusinessLogic.ElegirAlimentoAlAzar(IdentityManager.UsuarioActual.UserId, TipoComida.Almuerzo);
            mJueves.Text = _dietaBusinessLogic.ElegirAlimentoAlAzar(IdentityManager.UsuarioActual.UserId, TipoComida.Merienda);
            cJueves.Text = _dietaBusinessLogic.ElegirAlimentoAlAzar(IdentityManager.UsuarioActual.UserId, TipoComida.Cena);

            //viernes
            dViernes.Text = _dietaBusinessLogic.ElegirAlimentoAlAzar(IdentityManager.UsuarioActual.UserId, TipoComida.Desayuno);
            aViernes.Text = _dietaBusinessLogic.ElegirAlimentoAlAzar(IdentityManager.UsuarioActual.UserId, TipoComida.Almuerzo);
            mViernes.Text = _dietaBusinessLogic.ElegirAlimentoAlAzar(IdentityManager.UsuarioActual.UserId, TipoComida.Merienda);
            cViernes.Text = _dietaBusinessLogic.ElegirAlimentoAlAzar(IdentityManager.UsuarioActual.UserId, TipoComida.Cena);
        }


        private void Dieta_Load(object sender, EventArgs e)
        {

        }

        public void btnImprimir_Click(object sender, EventArgs e)
        {
            CaptureScreen();
            _printDocument.Print();
        }

        private void CaptureScreen()
        {
            var myGraphics = CreateGraphics();
            _memoryImage = new Bitmap(Size.Width, Size.Height, myGraphics);
            var memoryGraphics = Graphics.FromImage(_memoryImage);
            memoryGraphics.CopyFromScreen(Location.X, Location.Y, 0, 0, Size);
        }

        private void OnPrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(_memoryImage, 0, 0);
        }
    }
}
