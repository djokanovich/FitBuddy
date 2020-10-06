namespace FitBuddy.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicial : DbMigration
    {
        public override void Up()
        {
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
        }
    }
}
