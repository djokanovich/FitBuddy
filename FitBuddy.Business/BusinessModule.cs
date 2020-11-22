using Autofac;
using Common.Utilidades;
using FitBuddy.Business.Facade;
using FitBuddy.Business.Validators;
using FitBuddy.DataAccess;

namespace FitBuddy.Business
{
    public class BusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.RegisterModule<DataAccessModule>();

            builder.RegisterType<EmailService>().As<IEmailService>();
            builder.RegisterType<Md5HashingService>().As<IMd5HashingService>();
            builder.RegisterType<PasswordValidator>().As<IPasswordValidator>();
            builder.RegisterType<EmailValidator>().As<IEmailValidator>();

            builder.RegisterType<IntegridadBusinessLogic>().As<IIntegridadBusinessLogic>();
            
            builder.RegisterType<AgendarTurnoBusinessLogic>().As<IAgendarTurnoBusinessLogic>();
            builder.RegisterType<BackupBusinessLogic>().As<IBackupBusinessLogic>();
            builder.RegisterType<CargarAlimentoBusinessLogic>().As<ICargarAlimentoBusinessLogic>();
            builder.RegisterType<ConfiguraciónBusinessLogic>().As<IConfiguraciónBusinessLogic>();
            builder.RegisterType<CrearDietaBusinessLogic>().As<ICrearDietaBusinessLogic>();
            builder.RegisterType<CrearPlanEjercicioBusinessLogic>().As<ICrearPlanEjercicioBusinessLogic>();
            builder.RegisterType<DietaBusinessLogic>().As<IDietaBusinessLogic>();
            builder.RegisterType<EstadísticasBusinessLogic>().As<IEstadísticasBusinessLogic>();
            builder.RegisterType<EstadisticasCompletasBusinessLogic>().As<IEstadisticasCompletasBusinessLogic>();
            builder.RegisterType<GestionarPerfilBusinessLogic>().As<IGestionarPerfilBusinessLogic>();
            builder.RegisterType<LogInBusinessLogic>().As<ILogInBusinessLogic>();
            builder.RegisterType<PantallaPrincipalBusinessLogic>().As<IPantallaPrincipalBusinessLogic>();
            builder.RegisterType<RegistrarNuevoUsuarioBusinessLogic>().As<IRegistrarNuevoUsuarioBusinessLogic>();
        }
    }
}
