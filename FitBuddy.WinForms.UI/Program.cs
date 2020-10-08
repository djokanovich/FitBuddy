using System;
using System.Windows.Forms;
using FitBuddy.WinForms.UI.Formularios;
using Autofac;

namespace FitBuddy.WinForms.UI
{
    static class Program
    {
        private static IContainer _container;

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            _container = new Bootstrapper().Bootstrap();

            // FormBuilder es un singleton que resuelve formulario en tiempo de ejecución.
            // Le asigno el contenedor de IoC, para que lo use para resolver los formularios.
            // A su vez, FormBuilder lo resuelve el contenedor de IoC.
            // Es un problema del tipo del huevo y la gallina, y esta es una manera simple
            // de resolverlo (el doble sentido de la palabra 'resolver' es intencional).
            var formBuilder = _container.Resolve<IFormManager>();
            formBuilder.Container = _container;

            var fitBuddyApp = _container.Resolve<FitBuddyApp>();
            fitBuddyApp.AbrirVentanaPrincipal += AbrirVentanaPrincipal;
            fitBuddyApp.Iniciar();
        }

        private static void AbrirVentanaPrincipal(object sender, EventArgs e)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form ventanaPrincipal = _container.Resolve<AcercaDe>();
            Application.Run(ventanaPrincipal);
        }
    }
}
