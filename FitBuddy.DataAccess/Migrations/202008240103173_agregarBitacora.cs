namespace FitBuddy.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class agregarBitacora : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bitacoras",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdUsuario = c.Int(nullable: false),
                        Tipo = c.String(),
                        FechaHora = c.DateTime(nullable: false),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Bitacoras");
        }
    }
}
