namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EliminarEntidadesQueNoSeUsan : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Backups");
            DropTable("dbo.Bitacoras");
            DropTable("dbo.DiarioComidas");
            DropTable("dbo.DiarioEjercicios");
            DropTable("dbo.Dietas");
            DropTable("dbo.Domicilios");
            DropTable("dbo.Ejercicios");
            DropTable("dbo.Emails");
            DropTable("dbo.Idiomas");
            DropTable("dbo.Leyendas");
            DropTable("dbo.Permisoes");
            DropTable("dbo.PlanEjercicios");
            DropTable("dbo.Reclamoes");
            DropTable("dbo.Tablas");
            DropTable("dbo.Turnos");
        }
        
        public override void Down()
        {
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
                "dbo.Tablas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DVV = c.Int(nullable: false),
                        Nombre = c.String(),
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
                "dbo.PlanEjercicios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MinCalQuemadasDia = c.Int(nullable: false),
                        Tipo = c.String(),
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
                "dbo.Leyendas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
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
                "dbo.Bitacoras",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdUsuario = c.Int(nullable: false),
                        Tipo = c.String(),
                        FechaHora = c.DateTime(nullable: false),
                        Descripcion = c.String(),
                        DVH = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
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
            
        }
    }
}
