using Autofac;
using Common.Bitacora;
using FitBuddy.Business;
using FitBuddy.WinForms.UI.Formularios;

namespace FitBuddy.WinForms.UI
{
    internal class Bootstrapper
    {
        public IContainer Bootstrap()
        {
            var builder = new ContainerBuilder();

            builder.RegisterModule<BusinessModule>();

            var path = Properties.Settings.Default.ArchivoBitacora;
            var minimoNivelMensajesBitacora = Properties.Settings.Default.MinimoNivelMensajesBitacora;
            builder.RegisterGeneric(typeof(Bitacora<>))
                .As(typeof(IBitacora<>))
                .WithParameter("path", path)
                .WithParameter("minimoNivelMensajesBitacora", minimoNivelMensajesBitacora);

            builder.RegisterType<FitBuddyApp>().AsSelf();

            builder.RegisterType<FormManager>().As<IFormManager>()
                .SingleInstance();

            builder.RegisterType<AcercaDe>().AsSelf();
            builder.RegisterType<AgendarTurno>().AsSelf();
            builder.RegisterType<Backup>().AsSelf();
            builder.RegisterType<CargarAlimento>().AsSelf();
            builder.RegisterType<CargarDiarioEjercicios>().AsSelf();
            builder.RegisterType<CrearDieta>().AsSelf();
            builder.RegisterType<CrearPlanEjercicio>().AsSelf();
            builder.RegisterType<Estadísticas>().AsSelf();
            builder.RegisterType<GestionarPerfil>().AsSelf();
            builder.RegisterType<GestionarPlanAlimenticio>().AsSelf();
            builder.RegisterType<GestionarPlanEjercicios>().AsSelf();
            builder.RegisterType<LogIn>().AsSelf();
            builder.RegisterType<PantallaPrincipal>().AsSelf();
            builder.RegisterType<RegistrarNuevoUsuario>().AsSelf();

            var container = builder.Build();
            return container;
        }
    }
}
