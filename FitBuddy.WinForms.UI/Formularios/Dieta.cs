using FitBuddy.Business.Facade;
using FitBuddy.Entidades;
using FitBuddy.Entidades.Enums;
using FitBuddy.WinForms.UI.Security;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using TheArtOfDev.HtmlRenderer.PdfSharp;

namespace FitBuddy.WinForms.UI.Formularios
{
    public partial class Dieta : Form
    {
        private readonly IFormManager _formManager;
        private readonly IDietaBusinessLogic _dietaBusinessLogic;
        private DietaSemanal _dietaSemanal;
        private string _template;

        public Dieta(IFormManager formManager, IDietaBusinessLogic dietaBusinessLogic)
        {
            InitializeComponent();
            _formManager = formManager;
            _dietaBusinessLogic = dietaBusinessLogic;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            var usuarioId = IdentityManager.UsuarioActual.UserId;

            _dietaSemanal = _dietaBusinessLogic.CrearDietaSemanal(usuarioId);

            InitUi();
            InitTemplate();
        }

        private void InitUi()
        {
            //lunes
            lblDesayunoLunes.Text = _dietaSemanal[DayOfWeek.Monday, TipoComida.Desayuno];
            lblAlmuerzoLunes.Text = _dietaSemanal[DayOfWeek.Monday, TipoComida.Almuerzo];
            lblMeriendaLunes.Text = _dietaSemanal[DayOfWeek.Monday, TipoComida.Merienda];
            lblCenaLunes.Text = _dietaSemanal[DayOfWeek.Monday, TipoComida.Cena];

            //martes
            lblDesayunoMartes.Text = _dietaSemanal[DayOfWeek.Tuesday, TipoComida.Desayuno];
            lblAlmuerzoMartes.Text = _dietaSemanal[DayOfWeek.Tuesday, TipoComida.Almuerzo];
            lblMeriendaMartes.Text = _dietaSemanal[DayOfWeek.Tuesday, TipoComida.Merienda];
            lblCenaMartes.Text = _dietaSemanal[DayOfWeek.Tuesday, TipoComida.Cena];

            //miercoles
            lblDesayunoMiercoles.Text = _dietaSemanal[DayOfWeek.Wednesday, TipoComida.Desayuno];
            lblAlmuerzoMiercoles.Text = _dietaSemanal[DayOfWeek.Wednesday, TipoComida.Almuerzo];
            lblMeriendaMiercoles.Text = _dietaSemanal[DayOfWeek.Wednesday, TipoComida.Merienda];
            lblCenaMiercoles.Text = _dietaSemanal[DayOfWeek.Wednesday, TipoComida.Cena];

            //jueves
            lblDesayunoJueves.Text = _dietaSemanal[DayOfWeek.Thursday, TipoComida.Desayuno];
            lblAlmuerzoJueves.Text = _dietaSemanal[DayOfWeek.Thursday, TipoComida.Almuerzo];
            lblMeriendaJueves.Text = _dietaSemanal[DayOfWeek.Thursday, TipoComida.Merienda];
            lblCenaJueves.Text = _dietaSemanal[DayOfWeek.Thursday, TipoComida.Cena];

            //viernes
            lblDesayunoViernes.Text = _dietaSemanal[DayOfWeek.Friday, TipoComida.Desayuno];
            lblAlmuerzoViernes.Text = _dietaSemanal[DayOfWeek.Friday, TipoComida.Almuerzo];
            lblMeriendaViernes.Text = _dietaSemanal[DayOfWeek.Friday, TipoComida.Merienda];
            lblCenaViernes.Text = _dietaSemanal[DayOfWeek.Friday, TipoComida.Cena];
        }

        private void InitTemplate()
        {
            _template = Properties.Resources.TemplateDietaSemanal

                // Desayuno
                .Replace("{DesayunoLunes}", _dietaSemanal[DayOfWeek.Monday, TipoComida.Desayuno])
                .Replace("{DesayunoMartes}", _dietaSemanal[DayOfWeek.Tuesday, TipoComida.Desayuno])
                .Replace("{DesayunoMiercoles}", _dietaSemanal[DayOfWeek.Wednesday, TipoComida.Desayuno])
                .Replace("{DesayunoJueves}", _dietaSemanal[DayOfWeek.Thursday, TipoComida.Desayuno])
                .Replace("{DesayunoViernes}", _dietaSemanal[DayOfWeek.Friday, TipoComida.Desayuno])

                // Almuerzo
                .Replace("{AlmuerzoLunes}", _dietaSemanal[DayOfWeek.Monday, TipoComida.Almuerzo])
                .Replace("{AlmuerzoMartes}", _dietaSemanal[DayOfWeek.Tuesday, TipoComida.Almuerzo])
                .Replace("{AlmuerzoMiercoles}", _dietaSemanal[DayOfWeek.Wednesday, TipoComida.Almuerzo])
                .Replace("{AlmuerzoJueves}", _dietaSemanal[DayOfWeek.Thursday, TipoComida.Almuerzo])
                .Replace("{AlmuerzoViernes}", _dietaSemanal[DayOfWeek.Friday, TipoComida.Almuerzo])

                // Merienda
                .Replace("{MeriendaLunes}", _dietaSemanal[DayOfWeek.Monday, TipoComida.Merienda])
                .Replace("{MeriendaMartes}", _dietaSemanal[DayOfWeek.Tuesday, TipoComida.Merienda])
                .Replace("{MeriendaMiercoles}", _dietaSemanal[DayOfWeek.Wednesday, TipoComida.Merienda])
                .Replace("{MeriendaJueves}", _dietaSemanal[DayOfWeek.Thursday, TipoComida.Merienda])
                .Replace("{MeriendaViernes}", _dietaSemanal[DayOfWeek.Friday, TipoComida.Merienda])

                // Cena
                .Replace("{CenaLunes}", _dietaSemanal[DayOfWeek.Monday, TipoComida.Cena])
                .Replace("{CenaMartes}", _dietaSemanal[DayOfWeek.Tuesday, TipoComida.Cena])
                .Replace("{CenaMiercoles}", _dietaSemanal[DayOfWeek.Wednesday, TipoComida.Cena])
                .Replace("{CenaJueves}", _dietaSemanal[DayOfWeek.Thursday, TipoComida.Cena])
                .Replace("{CenaViernes}", _dietaSemanal[DayOfWeek.Friday, TipoComida.Cena]);
        }

        public void OnBtnExportarAPdfClick(object sender, EventArgs e)
        {
            string selectedPath;

            // TODO: Usar Microsoft.WindowsAPICodePack-Shell
            // https://stackoverflow.com/questions/11624298/how-to-use-openfiledialog-to-select-a-folder
            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                var result = folderBrowserDialog.ShowDialog();

                if (result != DialogResult.OK || string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                    return;

                selectedPath = folderBrowserDialog.SelectedPath;
            }

            object timestamp = DateTime.Now.ToString("yyyy-MM-dd-hh-mm-ss");
            var fileName = $"dieta-{timestamp}.pdf";
            var pdfFilePath = Path.Combine(selectedPath, fileName);

            var pageConfiguration = new PdfGenerateConfig
            {
                PageOrientation = PdfSharp.PageOrientation.Landscape,
                PageSize = PdfSharp.PageSize.A4,
                MarginTop = 40,
                MarginBottom = 40,
                MarginLeft = 40,
                MarginRight = 40,
            };
            var pdfDocument = PdfGenerator.GeneratePdf(_template, pageConfiguration);
            pdfDocument.Save(pdfFilePath);

            var dialogResult = MessageBox.Show(
                $"Se ha exportado la tabla al archivo {fileName} en la carpeta {selectedPath}.\n\n¿Desea abrir la carpeta?",
                "Exportar a PDF",
                MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
                Process.Start(selectedPath);
        }

        private void OnBtnAtrasClick(object sender, EventArgs e)
        {
            _formManager.Close(this);
        }

        private void Dieta_Load(object sender, EventArgs e)
        {

        }
    }
}
