using System;
using System.Windows.Forms;
using FitBuddy.WinForms.UI.Formularios;
using Autofac;
using System.Text;

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
            if (!parámetros.SonVálidos || parámetros.AyudaSolicitada || parámetros.VersiónSolicitada)
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

            if (parsedArgs.AyudaSolicitada)
            {
                var sb = new StringBuilder();
                sb.AppendLine("FitBuddy puede ejecutarse con los siguientes parámetros:");
                sb.AppendLine();
                sb.AppendLine("-ll LOGLEVEL");
                sb.AppendLine("--loglevel LOGLEVEL");
                sb.AppendLine("     Especifica el nivel de mensajes de bitácora, y tiene");
                sb.AppendLine("     prioridad sobre el archivo de configuración.");
                sb.AppendLine("     LOGLEVEL puede ser uno de estos valores:");
                sb.AppendLine("     DEBUG, INFO, ADVERTENCIA, ERROR, OFF");
                sb.AppendLine("-lf FILENAME");
                sb.AppendLine("--logfile FILENAME");
                sb.AppendLine("     Especifica el archivo en el cual guardar la bitácora, y");
                sb.AppendLine("     tiene prioridad sobre el archivo de configuración.");
                sb.AppendLine("-v");
                sb.AppendLine("--version");
                sb.AppendLine("/v");
                sb.AppendLine("     Muestra la versión de la aplicación.");
                sb.AppendLine("-h");
                sb.AppendLine("--help");
                sb.AppendLine("/h");
                sb.AppendLine("/?");
                sb.AppendLine("     Muestra esta ventana de ayuda, pero como lo estás");
                sb.AppendLine("     leyendo, seguramente no es ninguna novedad.");
                MessageBox.Show(sb.ToString());
            }

            if (parsedArgs.VersiónSolicitada)
            {
                var assembly = System.Reflection.Assembly.GetExecutingAssembly();
                var fileVersionInfo = System.Diagnostics.FileVersionInfo.GetVersionInfo(assembly.Location);
                var productName = fileVersionInfo.ProductName;
                var productVersion = fileVersionInfo.ProductVersion;
                MessageBox.Show($"{productName} versión {productVersion}.");
            }

            return parsedArgs;
        }
    }
}
