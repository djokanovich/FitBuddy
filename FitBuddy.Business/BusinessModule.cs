using Autofac;
using FitBuddy.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitBuddy.Business
{
    public class BusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.RegisterModule<DataAccessModule>();

            builder.RegisterType<ServicioIntegridadBLL>().As<IServicioIntegridadBLL>();
            builder.RegisterType<gesUsuario>().AsSelf();
        }
    }
}
