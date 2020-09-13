namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class agregarReclamos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Reclamoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Reclamoes");
        }
    }
}
