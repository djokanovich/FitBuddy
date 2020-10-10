using System;
using System.Windows.Forms;
using FitBuddy.WinForms.UI.Formularios;
using Autofac;
using System.Linq;

namespace FitBuddy.WinForms.UI
{
    static class Program
    {
        private static IContainer _container;

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            var parámetros = ParseArgs(args);
            if (!parámetros.SonVálidos)
                return;

            _container = new Bootstrapper().Bootstrap(parámetros);

            // FormManager es un singleton que resuelve formulario en tiempo de ejecución.
            // Le asigno el contenedor de IoC, para que lo use para resolver los formularios.
            // A su vez, FormManager lo resuelve el contenedor de IoC.
            // Es un problema del tipo del huevo y la gallina, y esta es una manera simple
            // de resolverlo (el doble sentido de la palabra 'resolver' es intencional).
            var formManager = _container.Resolve<IFormManager>();
            formManager.Container = _container;

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

        private static ParsedArgs ParseArgs(string[] args)
        {
            var parsedArgs = ArgsParser.Parse(args);
            if (!parsedArgs.SonVálidos)
                MessageBox.Show(string.Join("\n", parsedArgs.Errores));

            return parsedArgs;
        }
    }
}
