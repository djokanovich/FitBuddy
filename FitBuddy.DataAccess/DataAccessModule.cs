using Autofac;
using FitBuddy.DataAccess.Repositorios;
using FitBuddy.DataAccess.Services;

namespace FitBuddy.DataAccess
{
    public class DataAccessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.RegisterType<AppDbContext>().AsSelf()
                .SingleInstance();

            builder.RegisterType<DbBackupSevice>().As<IDbBackupSevice>();
            builder.RegisterType<DbIntegridadService>().As<IDbIntegridadService>();
            
            builder.RegisterType<MedicoRepositorio>().As<IMedicoRepositorio>();
            builder.RegisterType<PacienteRepositorio>().As<IPacienteRepositorio>();
            builder.RegisterType<UsuarioRepositorio>().As<IUsuarioRepositorio>();
        }
    }
}
