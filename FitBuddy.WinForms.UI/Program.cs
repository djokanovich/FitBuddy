using Common.Bitacora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FitBuddy.WinForms.UI.Formularios;
using FitBuddy.WinForms.UI.Security;
using FitBuddy.Business;
using Autofac;

namespace FitBuddy.WinForms.UI
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Registro los tipos de datos a ser inyectados por el Contenedor de IoC.
            var bootstrapper = new Bootstrapper();
            var container = bootstrapper.Bootstrap();


            // Verificar los códigos de verificación.


            var servicioIntegridadBll = new ServicioIntegridadBLL();

            // TODO Borrar
            //var path = Properties.Settings.Default.ArchivoBitacora;
            //var bitacora = new Bitacora(path);

            var bitacora = container.Resolve<IBitacora>();


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

            var acercaDe = container.Resolve<AcercaDe>();
            Application.Run(acercaDe);
        }
    }
}
