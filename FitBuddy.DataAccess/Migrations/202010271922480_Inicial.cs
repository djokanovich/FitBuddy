namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Comidas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripción = c.String(),
                        TipoComida = c.Int(nullable: false),
                        Objetivo = c.Byte(nullable: false),
                        Contiene = c.Int(nullable: false),
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
                        Altura = c.Int(nullable: false),
                        Edad = c.Int(nullable: false),
                        ContornoBrazoEnCm = c.Int(nullable: false),
                        ContornoCaderaEnCm = c.Int(nullable: false),
                        ContornoCinturaEnCm = c.Int(nullable: false),
                        ContornoMusloEnCm = c.Int(nullable: false),
                        Objetivo = c.Int(nullable: false),
                        Peso = c.Int(nullable: false),
                        FechaRegistroPerfil = c.DateTime(nullable: false),
                        Genero = c.Byte(nullable: false),
                        Alergias = c.Int(nullable: false),
                        FrecuenciaActual = c.Int(nullable: false),
                        DisposicionDiariaHoras = c.Int(nullable: false),
                        DisposicionSemanalDias = c.Int(nullable: false),
                        ObjetivoBuscado = c.Int(nullable: false),
                        Antecedentes = c.Int(nullable: false),
                        UsuarioId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Usuarios", t => t.UsuarioId, cascadeDelete: true)
                .Index(t => t.UsuarioId);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        Estado = c.Int(nullable: false),
                        IdIdioma = c.Int(nullable: false),
                        IntentosFallidos = c.Int(nullable: false),
                        Md5Hash = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pacientes", "UsuarioId", "dbo.Usuarios");
            DropIndex("dbo.Pacientes", new[] { "UsuarioId" });
            DropTable("dbo.Usuarios");
            DropTable("dbo.Pacientes");
            DropTable("dbo.Medicos");
            DropTable("dbo.Comidas");
        }
    }
}
