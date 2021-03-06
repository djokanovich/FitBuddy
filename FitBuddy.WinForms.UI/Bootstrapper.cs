﻿using Autofac;
using Common.Bitacora;
using Common.Utilidades;
using FitBuddy.Business;
using FitBuddy.WinForms.UI.Animación;
using FitBuddy.WinForms.UI.Formularios;

namespace FitBuddy.WinForms.UI
{
    internal class Bootstrapper
    {
        public IContainer Bootstrap(ParsedArgs parsedArgs)
        {
            var builder = new ContainerBuilder();

            builder.RegisterModule<BusinessModule>();

            var path = parsedArgs.LogFilename ?? Properties.Settings.Default.ArchivoBitacora;
            var minimoNivelMensajesBitacora = parsedArgs.LogLevel ?? Properties.Settings.Default.MinimoNivelMensajesBitacora;
            builder.RegisterGeneric(typeof(Bitacora<>))
                .As(typeof(IBitacora<>))
                .WithParameter("path", path)
                .WithParameter("minimoNivelMensajesBitacora", minimoNivelMensajesBitacora)
                .SingleInstance();

            builder.RegisterType<RandomNumberGeneratorService>().AsSelf()
                .SingleInstance();

            builder.RegisterType<FitBuddyApp>().AsSelf()
                .SingleInstance();

            builder.RegisterType<FormManager>().As<IFormManager>()
                .SingleInstance();

            builder.RegisterType<Animar>().AsSelf();

            builder.RegisterType<AcercaDe>().AsSelf();
            builder.RegisterType<AgendarTurno>().AsSelf();
            builder.RegisterType<Backup>().AsSelf();
            builder.RegisterType<CargarAlimento>().AsSelf();
            builder.RegisterType<CargarDiarioEjercicios>().AsSelf();
            builder.RegisterType<CrearDieta>().AsSelf();
            builder.RegisterType<CrearPlanEjercicio>().AsSelf();
            builder.RegisterType<Dieta>().AsSelf();
            builder.RegisterType<Estadísticas>().AsSelf();
            builder.RegisterType<EstadísticasCompletas>().AsSelf();
            builder.RegisterType<GestionarPerfil>().AsSelf();
            builder.RegisterType<GestionarPlanAlimenticio>().AsSelf();
            builder.RegisterType<GestionarPlanEjercicios>().AsSelf();
            builder.RegisterType<LogIn>().AsSelf();
            builder.RegisterType<PantallaPrincipal>().AsSelf();
            builder.RegisterType<RegistrarNuevoUsuario>().AsSelf();
            builder.RegisterType<Configuracion>().AsSelf();
            builder.RegisterType<ContactarProfesional>().AsSelf();


            var container = builder.Build();
            return container;
        }
    }
}
