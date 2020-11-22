namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AgregarTablaIdiomas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Idiomas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Código = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Usuarios", "IdiomaId", c => c.Int());
            CreateIndex("dbo.Usuarios", "IdiomaId");
            AddForeignKey("dbo.Usuarios", "IdiomaId", "dbo.Idiomas", "Id");
            DropColumn("dbo.Usuarios", "IdIdioma");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Usuarios", "IdIdioma", c => c.Int(nullable: false));
            DropForeignKey("dbo.Usuarios", "IdiomaId", "dbo.Idiomas");
            DropIndex("dbo.Usuarios", new[] { "IdiomaId" });
            DropColumn("dbo.Usuarios", "IdiomaId");
            DropTable("dbo.Idiomas");
        }
    }
}
