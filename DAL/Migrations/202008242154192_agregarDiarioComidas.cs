namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class agregarDiarioComidas : DbMigration
    {
        public override void Up()
        {
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
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DiarioComidas");
        }
    }
}
