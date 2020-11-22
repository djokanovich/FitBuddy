namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IdiomaNoNuloEnUsuario : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Usuarios", "IdiomaId", "dbo.Idiomas");
            DropIndex("dbo.Usuarios", new[] { "IdiomaId" });
            AlterColumn("dbo.Usuarios", "IdiomaId", c => c.Int(nullable: false));
            CreateIndex("dbo.Usuarios", "IdiomaId");
            AddForeignKey("dbo.Usuarios", "IdiomaId", "dbo.Idiomas", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Usuarios", "IdiomaId", "dbo.Idiomas");
            DropIndex("dbo.Usuarios", new[] { "IdiomaId" });
            AlterColumn("dbo.Usuarios", "IdiomaId", c => c.Int());
            CreateIndex("dbo.Usuarios", "IdiomaId");
            AddForeignKey("dbo.Usuarios", "IdiomaId", "dbo.Idiomas", "Id");
        }
    }
}
