using Autofac;
using Common.Bitacora;
using FitBuddy.WinForms.UI.Formularios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitBuddy.WinForms.UI
{
    internal class Bootstrapper
    {
        public IContainer Bootstrap()
        {
            var builder = new ContainerBuilder();

            var logPath = Properties.Settings.Default.ArchivoBitacora;
            builder.RegisterType<Bitacora>().As<IBitacora>()
                .WithParameter("path", logPath);

            builder.RegisterType<AcercaDe>().AsSelf();
            //builder.RegisterType<LogIn>().AsSelf();
            //builder.RegisterType<RegistrarNuevoUsuario>().AsSelf();

            return builder.Build();
        }
    }
}
