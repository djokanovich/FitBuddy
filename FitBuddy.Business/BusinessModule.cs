using Autofac;
using FitBuddy.DataAccess;

namespace FitBuddy.Business
{
    public class BusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.RegisterModule<DataAccessModule>();

            builder.RegisterType<ServicioIntegridadBLL>().As<IServicioIntegridadBLL>();
            builder.RegisterType<MedicoFacade>().As<IMedicoFacade>();
            builder.RegisterType<PacienteFacade>().As<IPacienteFacade>();
            builder.RegisterType<UsuarioFacade>().As<IUsuarioFacade>();
        }
    }
}
