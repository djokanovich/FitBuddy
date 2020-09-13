namespace DAL2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModeloDeDatos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Backups",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        DBName = c.String(),
                        FileName = c.String(),
                        Path = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Bitacoras",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdUsuario = c.Int(nullable: false),
                        Tipo = c.String(),
                        FechaHora = c.DateTime(nullable: false),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Comidas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Calorias = c.Int(nullable: false),
                        Nombre = c.String(),
                        Porcion = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DiarioComidas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Calorias = c.Int(nullable: false),
                        Porcion = c.Int(nullable: false),
                        NombreComida = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DiarioEjercicios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Fecha = c.DateTime(nullable: false),
                        IdEjercicio = c.Int(nullable: false),
                        Tiempo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Dietas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MaxCalDia = c.Int(nullable: false),
                        MinCalDia = c.Int(nullable: false),
                        Tipo = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Domicilios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Altura = c.Int(nullable: false),
                        Calle = c.String(),
                        Ciudad = c.String(),
                        CodPostal = c.Int(nullable: false),
                        Depto = c.String(),
                        Indicaciones = c.String(),
                        Pais = c.String(),
                        Provincia = c.String(),
                        Piso = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Ejercicios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CalQuemadas = c.Int(nullable: false),
                        Repeticiones = c.Int(nullable: false),
                        Tiempo = c.Int(nullable: false),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Emails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CC = c.String(),
                        Emisor = c.String(),
                        Mensaje = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Idiomas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Leyendas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Medicos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        DireccionConsultorio = c.String(),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        Telefono = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Pacientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PerfilDietas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AlergHuevo = c.Boolean(nullable: false),
                        AlergLacteos = c.Boolean(nullable: false),
                        AlergMariscos = c.Boolean(nullable: false),
                        AlergSecos = c.Boolean(nullable: false),
                        AlergTomates = c.Boolean(nullable: false),
                        Celiaco = c.Boolean(nullable: false),
                        Vegano = c.Boolean(nullable: false),
                        Vegetariano = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PerfilFisicoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DispDiaria = c.Int(nullable: false),
                        DispSemanal = c.Int(nullable: false),
                        IdPerfilFisico = c.Int(nullable: false),
                        ProblemasCardio = c.Boolean(nullable: false),
                        ProblemasResp = c.Boolean(nullable: false),
                        ProblemasTraumat = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PerfilPacientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Altura = c.Int(nullable: false),
                        ContBrazo = c.Int(nullable: false),
                        ContCadera = c.Int(nullable: false),
                        ContCintura = c.Int(nullable: false),
                        ContMuslo = c.Int(nullable: false),
                        Objetivo = c.Int(nullable: false),
                        Peso = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Permisoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PlanEjercicios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MinCalQuemadasDia = c.Int(nullable: false),
                        Tipo = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Reclamoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tablas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DVV = c.Int(nullable: false),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Turnoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Fecha = c.DateTime(nullable: false),
                        Hora = c.DateTime(nullable: false),
                        IdPaciente = c.Int(nullable: false),
                        IdMedico = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Apellido = c.String(),
                        DVH = c.Int(nullable: false),
                        Estado = c.Int(nullable: false),
                        IdIdioma = c.Int(nullable: false),
                        IntentosFallidos = c.Int(nullable: false),
                        Nombre = c.String(),
                        Password = c.String(),
                        Username = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Usuarios");
            DropTable("dbo.Turnoes");
            DropTable("dbo.Tablas");
            DropTable("dbo.Reclamoes");
            DropTable("dbo.PlanEjercicios");
            DropTable("dbo.Permisoes");
            DropTable("dbo.PerfilPacientes");
            DropTable("dbo.PerfilFisicoes");
            DropTable("dbo.PerfilDietas");
            DropTable("dbo.Pacientes");
            DropTable("dbo.Medicos");
            DropTable("dbo.Leyendas");
            DropTable("dbo.Idiomas");
            DropTable("dbo.Emails");
            DropTable("dbo.Ejercicios");
            DropTable("dbo.Domicilios");
            DropTable("dbo.Dietas");
            DropTable("dbo.DiarioEjercicios");
            DropTable("dbo.DiarioComidas");
            DropTable("dbo.Comidas");
            DropTable("dbo.Bitacoras");
            DropTable("dbo.Backups");
        }
    }
}
