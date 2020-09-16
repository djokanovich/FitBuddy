using Bitacora;
using GUI.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.Services;

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

            var servicioIntegridadDb = new ServicioIntegridadDb();

            

            if (!servicioIntegridadDb.DbTieneIntegridad())
            {
                MessageBox.Show("Se vió afectada la integridad del sistema. Contacte con un administrador");
                return;
            }
            
    
            var path = Properties.Settings.Default.ArchivoBitacora;

            var bitacora = new ServicioBitacora(path);
            bitacora.Agregar("Aplicación iniciada.");

            Thread.CurrentPrincipal = new CustomPrincipal();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AcercaDe());
        }
    }
}
