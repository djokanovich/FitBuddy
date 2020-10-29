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
        private readonly IFormManager _formManager;
        private readonly IDietaBusinessLogic _dietaBusinessLogic;
        private PrintDocument _printDocument;
        private Bitmap _memoryImage;

        public Dieta(IFormManager formManager, IDietaBusinessLogic dietaBusinessLogic)
        {
            InitializeComponent();
            _formManager = formManager;
            _dietaBusinessLogic = dietaBusinessLogic;

            _printDocument = new PrintDocument();
            _printDocument.PrintPage += OnPrintPage;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            var usuarioId = IdentityManager.UsuarioActual.UserId;

            //lunes
            lblDesayunoLunes.Text = _dietaBusinessLogic.ElegirAlimentoAlAzar(TipoComida.Desayuno, usuarioId);
            lblAlmuerzoLunes.Text = _dietaBusinessLogic.ElegirAlimentoAlAzar(TipoComida.Almuerzo, usuarioId);
            lblMeriendaLunes.Text = _dietaBusinessLogic.ElegirAlimentoAlAzar(TipoComida.Merienda, usuarioId);
            lblCenaLunes.Text = _dietaBusinessLogic.ElegirAlimentoAlAzar(TipoComida.Cena, usuarioId);

            //martes
            lblDesayunoMartes.Text = _dietaBusinessLogic.ElegirAlimentoAlAzar(TipoComida.Desayuno, usuarioId);
            lblAlmuerzoMartes.Text = _dietaBusinessLogic.ElegirAlimentoAlAzar(TipoComida.Almuerzo, usuarioId);
            lblMeriendaMartes.Text = _dietaBusinessLogic.ElegirAlimentoAlAzar(TipoComida.Merienda, usuarioId);
            lblCenaMartes.Text = _dietaBusinessLogic.ElegirAlimentoAlAzar(TipoComida.Cena, usuarioId);

            //miercoles
            lblDesayunoMiercoles.Text = _dietaBusinessLogic.ElegirAlimentoAlAzar(TipoComida.Desayuno, usuarioId);
            lblAlmuerzoMiercoles.Text = _dietaBusinessLogic.ElegirAlimentoAlAzar(TipoComida.Almuerzo, usuarioId);
            lblMeriendaMiercoles.Text = _dietaBusinessLogic.ElegirAlimentoAlAzar(TipoComida.Merienda, usuarioId);
            lblCenaMiercoles.Text = _dietaBusinessLogic.ElegirAlimentoAlAzar(TipoComida.Cena, usuarioId);


            //jueves
            lblDesayunoJueves.Text = _dietaBusinessLogic.ElegirAlimentoAlAzar(TipoComida.Desayuno, usuarioId);
            lblAlmuerzoJueves.Text = _dietaBusinessLogic.ElegirAlimentoAlAzar(TipoComida.Almuerzo, usuarioId);
            lblMeriendaJueves.Text = _dietaBusinessLogic.ElegirAlimentoAlAzar(TipoComida.Merienda, usuarioId);
            lblCenaJueves.Text = _dietaBusinessLogic.ElegirAlimentoAlAzar(TipoComida.Cena, usuarioId);

            //viernes
            lblDesayunoViernes.Text = _dietaBusinessLogic.ElegirAlimentoAlAzar(TipoComida.Desayuno, usuarioId);
            lblAlmuerzoViernes.Text = _dietaBusinessLogic.ElegirAlimentoAlAzar(TipoComida.Almuerzo, usuarioId);
            lblMeriendaViernes.Text = _dietaBusinessLogic.ElegirAlimentoAlAzar(TipoComida.Merienda, usuarioId);
            lblCenaViernes.Text = _dietaBusinessLogic.ElegirAlimentoAlAzar(TipoComida.Cena, usuarioId);
        }


        public void btnImprimir_Click(object sender, EventArgs e)
        {
            var printDialog = new PrintDialog();
            printDialog.Document = _printDocument;
            printDialog.PrinterSettings.DefaultPageSettings.Landscape = false;
            var dialogResult = printDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                CaptureScreen();
                _printDocument.Print();
            }
        }

        private void CaptureScreen()
        {
            var graphics = CreateGraphics();
            _memoryImage = new Bitmap(Size.Width, Size.Height, graphics);
            var memoryGraphics = Graphics.FromImage(_memoryImage);
            memoryGraphics.CopyFromScreen(Location.X, Location.Y + 40, 0, 0, new Size(Size.Width, 475));
        }

        private void OnPrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(_memoryImage, 0, 0);
        }

        private void OnBtnAtrasClick(object sender, EventArgs e)
        {
            _formManager.Close(this);
        }
    }
}
