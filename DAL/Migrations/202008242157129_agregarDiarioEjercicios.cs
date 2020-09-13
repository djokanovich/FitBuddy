namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class agregarDiarioEjercicios : DbMigration
    {
        public override void Up()
        {
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
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DiarioEjercicios");
        }
    }
}
