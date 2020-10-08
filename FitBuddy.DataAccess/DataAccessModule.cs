﻿using Autofac;
using FitBuddy.DataAccess.Repositorio;

namespace FitBuddy.DataAccess
{
    public class DataAccessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.RegisterType<AppDbContext>().AsSelf()
                .SingleInstance();

            builder.RegisterType<MedicoDAL>().As<IMedicoDAL>();
            builder.RegisterType<PacienteDAL>().As<IPacienteDAL>();
            builder.RegisterType<UsuarioDAL>().As<IUsuarioDAL>();
        }
    }
}