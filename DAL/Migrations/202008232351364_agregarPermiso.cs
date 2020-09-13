namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class agregarPermiso : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Permisoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Permisoes");
        }
    }
}
