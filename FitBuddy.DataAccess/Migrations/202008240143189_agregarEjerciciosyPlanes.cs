namespace FitBuddy.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class agregarEjerciciosyPlanes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ejercicios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CalQuemadas = c.Int(nullable: false),
                        Repeticiones = c.Int(nullable: false),
                        Tiempo = c.Int(nullable: false),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PerfilFisicoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DispDiaria = c.Int(nullable: false),
                        DispSemanal = c.Int(nullable: false),
                        IdPerfilFisico = c.Int(nullable: false),
                        ProblemasCardio = c.Boolean(nullable: false),
                        ProblemasResp = c.Boolean(nullable: false),
                        ProblemasTraumat = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PlanEjercicios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MinCalQuemadasDia = c.Int(nullable: false),
                        Tipo = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PlanEjercicios");
            DropTable("dbo.PerfilFisicoes");
            DropTable("dbo.Ejercicios");
        }
    }
}
