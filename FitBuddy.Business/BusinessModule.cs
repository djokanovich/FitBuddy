using Autofac;
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

            builder.RegisterType<BackupBusinessLogic>().As<IBackupBusinessLogic>();
            builder.RegisterType<IntegridadBusinessLogic>().As<IIntegridadBusinessLogic>();
            builder.RegisterType<MedicoFacade>().As<IMedicoFacade>();
            builder.RegisterType<PacienteFacade>().As<IPacienteFacade>();
            builder.RegisterType<UsuarioFacade>().As<IUsuarioFacade>();
        }
    }
}
