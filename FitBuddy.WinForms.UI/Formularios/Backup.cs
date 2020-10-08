using FitBuddy.Business.Facade;
using System;
using System.Windows.Forms;

namespace FitBuddy.WinForms.UI.Formularios
{
    public partial class Backup : Form
    {
        private readonly IBackupBusinessLogic _backupBusinessLogic;

        public Backup(IBackupBusinessLogic backupBusinessLogic)
        {
            InitializeComponent();
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
                if (_backupBusinessLogic.EsCrearBackupExitoso(fileName))
                    MessageBox.Show("Backup creado con éxito.");
                else
                    MessageBox.Show("No se pudo crear el backup.");
            }
        }
    }
}
