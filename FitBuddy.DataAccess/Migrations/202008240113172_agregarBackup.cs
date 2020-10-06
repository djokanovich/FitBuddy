namespace FitBuddy.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class agregarBackup : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Backups",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        DBName = c.String(),
                        FileName = c.String(),
                        Path = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Backups");
        }
    }
}
