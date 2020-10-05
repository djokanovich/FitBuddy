namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fecharegistro1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pacientes", "Edad", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Pacientes", "Edad");
        }
    }
}
