namespace FitBuddy.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class agregarDietasyComidas : DbMigration
    {
        public override void Up()
        {
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
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PerfilDietas");
            DropTable("dbo.Dietas");
            DropTable("dbo.Comidas");
        }
    }
}
