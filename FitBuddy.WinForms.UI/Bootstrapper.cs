using Autofac;
using Common.Bitacora;
using FitBuddy.Business;
using FitBuddy.WinForms.UI.Formularios;
using FitBuddy.WinForms.UI.Security;
using System.Security.Principal;

namespace FitBuddy.WinForms.UI
{
    internal class Bootstrapper
    {
        public IContainer Bootstrap()
        {
            var builder = new ContainerBuilder();

            var logPath = Properties.Settings.Default.ArchivoBitacora;
            builder.RegisterModule<BusinessModule>();

            builder.RegisterType<Bitacora>().As<IBitacora>()
                .WithParameter("path", logPath);

            builder.RegisterType<FitBuddyApp>().AsSelf();

            builder.RegisterType<CustomPrincipal>().As<IPrincipal>();

            builder.RegisterType<FormBuilder>().As<IFormBuilder>()
                .SingleInstance();

            builder.RegisterType<AcercaDe>().AsSelf();
            builder.RegisterType<LogIn>().AsSelf();
            builder.RegisterType<RegistrarNuevoUsuario>().AsSelf();

            var container = builder.Build();
            return container;
        }
    }
}
