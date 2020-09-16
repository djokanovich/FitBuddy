namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class agregaDVH : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bitacoras", "DVH", c => c.Int(nullable: false));
            AddColumn("dbo.Comidas", "DVH", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Comidas", "DVH");
            DropColumn("dbo.Bitacoras", "DVH");
        }
    }
}
