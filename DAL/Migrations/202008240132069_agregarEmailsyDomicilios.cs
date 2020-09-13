namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class agregarEmailsyDomicilios : DbMigration
    {
        public override void Up()
        {
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
                "dbo.Emails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CC = c.String(),
                        Emisor = c.String(),
                        Mensaje = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Emails");
            DropTable("dbo.Domicilios");
        }
    }
}
