namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addgenero : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pacientes", "Genero", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Pacientes", "Genero");
        }
    }
}
