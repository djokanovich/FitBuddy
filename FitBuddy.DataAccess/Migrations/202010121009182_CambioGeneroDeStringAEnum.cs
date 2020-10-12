namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CambioGeneroDeStringAEnum : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Pacientes", "Genero", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Pacientes", "Genero", c => c.String());
        }
    }
}
