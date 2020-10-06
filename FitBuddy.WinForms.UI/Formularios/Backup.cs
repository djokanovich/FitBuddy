using BLL;
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
    public partial class Backup : Form
    {
        public Backup()
        {
            InitializeComponent();
        }

        private void OnBtnCrearBackupClick(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                InitialDirectory = "c:\\",
                Filter = "Archivos de back-up|*.bak",
                CheckFileExists = false,
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                var servicioBackup = new ServicioBackupBLL();
                int resultado = servicioBackup.CrearBackup(fileName);
                if (resultado == 0)
                {
                    MessageBox.Show("Backup creado con éxito");
                }
                else
                {
                    MessageBox.Show("Consulte al administrador");
                }
            }
        }
    }
}
