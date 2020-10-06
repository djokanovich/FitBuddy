using Bitacora;
using GUI.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace GUI
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //log4net.config.xmlconfigurator.configure();
            //var logger = log4net.logmanager.getlogger(typeof(program));
            //logger.info("fitbuddy acaba de iniciarse.");

            // Verificar los códigos de verificación.

            var servicioIntegridadBll = new ServicioIntegridadBLL();

            var path = Properties.Settings.Default.ArchivoBitacora;

            var bitacora = new ServicioBitacora(path);


            if (!servicioIntegridadBll.DbTieneIntegridad())
            {
                MessageBox.Show("Se vió afectada la integridad del sistema. ¿Desea notificar al administrador?","Atención", MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Exclamation);
                bitacora.Agregar("La aplicación inició con un problema de integridad en la base de datos.");
            }

            Thread.CurrentPrincipal = new CustomPrincipal();
            bitacora.Agregar("Aplicación iniciada.");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AcercaDe());
        }
    }
}
