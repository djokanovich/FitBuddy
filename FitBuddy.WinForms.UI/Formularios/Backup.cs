using Common.Bitacora;
using FitBuddy.Business.Facade;
using System;
using System.Windows.Forms;

namespace FitBuddy.WinForms.UI.Formularios
{
    public partial class Backup : Form
    {
        private readonly IFormManager _formManager;
        private readonly IBitacora<Backup> _bitacora;
        private readonly IBackupBusinessLogic _backupBusinessLogic;

        public Backup(IFormManager formManager, IBitacora<Backup> bitacora, IBackupBusinessLogic backupBusinessLogic)
        {
            InitializeComponent();
            _formManager = formManager;
            _bitacora = bitacora;
            _backupBusinessLogic = backupBusinessLogic;
        }

        private void OnBtnCrearBackupClick(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                InitialDirectory = "C:\\",
                Filter = "Archivos de backup (*.bak)|*.bak",
                CheckFileExists = false, // Falso, para poder seleccionar un archivo inexistente.
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var fileName = openFileDialog.FileName;
                _bitacora.Debug($"Solicitud para crear backup en el archivo {fileName}.");

                if (_backupBusinessLogic.EsCrearBackupExitoso(fileName))
                    MessageBox.Show("Backup creado con éxito.");
                else
                    MessageBox.Show("No se pudo crear el backup.");
            }
        }

        private void OnBtnAtrasClick(object sender, EventArgs e)
        {
            _formManager.Close(this);
        }
    }
}
