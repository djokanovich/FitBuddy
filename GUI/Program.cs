using Bitacora;
using GUI.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

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
