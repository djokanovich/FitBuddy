namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DefinirEInicializarComida : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Comidas", "Descripción", c => c.String());
            AddColumn("dbo.Comidas", "TipoComida", c => c.Int(nullable: false));
            AddColumn("dbo.Comidas", "Objetivo", c => c.Int(nullable: false));
            AddColumn("dbo.Comidas", "TipoAlimento", c => c.Int(nullable: false));
            DropColumn("dbo.Comidas", "Calorias");
            DropColumn("dbo.Comidas", "Nombre");
            DropColumn("dbo.Comidas", "Porcion");
            DropColumn("dbo.Comidas", "DVH");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Comidas", "DVH", c => c.Int(nullable: false));
            AddColumn("dbo.Comidas", "Porcion", c => c.Int(nullable: false));
            AddColumn("dbo.Comidas", "Nombre", c => c.String());
            AddColumn("dbo.Comidas", "Calorias", c => c.Int(nullable: false));
            DropColumn("dbo.Comidas", "TipoAlimento");
            DropColumn("dbo.Comidas", "Objetivo");
            DropColumn("dbo.Comidas", "TipoComida");
            DropColumn("dbo.Comidas", "Descripción");
        }
    }
}
