namespace FitBuddy.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class agregarPerfilPcte : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pacientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
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
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PerfilPacientes");
            DropTable("dbo.Pacientes");
        }
    }
}
