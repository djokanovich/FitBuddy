namespace FitBuddy.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class agregarDiarioTurnos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Turnos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Fecha = c.DateTime(nullable: false),
                        Hora = c.DateTime(nullable: false),
                        IdPaciente = c.Int(nullable: false),
                        IdMedico = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Turnoes");
        }
    }
}
