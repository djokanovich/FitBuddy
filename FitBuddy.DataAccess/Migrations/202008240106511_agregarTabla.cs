namespace FitBuddy.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class agregarTabla : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tablas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DVV = c.Int(nullable: false),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tablas");
        }
    }
}
