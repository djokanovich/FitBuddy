using Autofac;
using FitBuddy.DataAccess.Repositorios;
using FitBuddy.DataAccess.Repositorios.Genérico;
using FitBuddy.DataAccess.Services;
using FitBuddy.Entidades;

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

            builder.RegisterType<ComidaRepositorio>().As<IRepositorio<Comida>>();
            builder.RegisterType<ComposiciónAlimentoRepositorio>().As<IRepositorio<ComposiciónAlimento>>();
            builder.RegisterType<MédicoRepositorio>().As<IRepositorio<Medico>>();
            builder.RegisterType<PacienteRepositorio>().As<IRepositorio<Paciente>>();
            builder.RegisterType<UsuarioRepositorio>().As<IRepositorio<Usuario>>();
        }
    }
}
