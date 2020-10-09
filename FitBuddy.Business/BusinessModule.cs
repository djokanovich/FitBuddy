using Autofac;
using Common.Utilidades;
using Common.Utilidades.Validators;
using FitBuddy.Business.Facade;
using FitBuddy.DataAccess;

namespace FitBuddy.Business
{
    public class BusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.RegisterModule<DataAccessModule>();

            builder.RegisterType<HashService>().As<IHashService>();
            builder.RegisterType<PasswordValidator>().As<IPasswordValidator>();
            builder.RegisterType<EmailValidator>().As<IEmailValidator>();

            builder.RegisterType<IntegridadBusinessLogic>().As<IIntegridadBusinessLogic>();

            builder.RegisterType<AgendarTurnoBusinessLogic>().As<IAgendarTurnoBusinessLogic>();
            builder.RegisterType<BackupBusinessLogic>().As<IBackupBusinessLogic>();
            builder.RegisterType<CrearDietaBusinessLogic>().As<ICrearDietaBusinessLogic>();
            builder.RegisterType<EstadisticasBusinessLogic>().As<IEstadisticasBusinessLogic>();
            builder.RegisterType<GestionarPerfilBusinessLogic>().As<IGestionarPerfilBusinessLogic>();
            builder.RegisterType<LogInBusinessLogic>().As<ILogInBusinessLogic>();
            builder.RegisterType<PantallaPrincipalBusinessLogic>().As<IPantallaPrincipalBusinessLogic>();
            builder.RegisterType<RegistrarNuevoUsuarioBusinessLogic>().As<IRegistrarNuevoUsuarioBusinessLogic>();
        }
    }
}
