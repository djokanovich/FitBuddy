namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NombresMasClarosEnPaciente : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pacientes", "ContornoBrazoEnCm", c => c.Int(nullable: false));
            AddColumn("dbo.Pacientes", "ContornoCaderaEnCm", c => c.Int(nullable: false));
            AddColumn("dbo.Pacientes", "ContornoCinturaEnCm", c => c.Int(nullable: false));
            AddColumn("dbo.Pacientes", "ContornoMusloEnCm", c => c.Int(nullable: false));
            AddColumn("dbo.Pacientes", "Antecedentes", c => c.Int(nullable: false));
            AlterColumn("dbo.Comidas", "Objetivo", c => c.Byte(nullable: false));
            AlterColumn("dbo.Pacientes", "Genero", c => c.Byte(nullable: false));
            DropColumn("dbo.Pacientes", "ContBrazo");
            DropColumn("dbo.Pacientes", "ContCadera");
            DropColumn("dbo.Pacientes", "ContCintura");
            DropColumn("dbo.Pacientes", "ContMuslo");
            DropColumn("dbo.Pacientes", "ProblemasCardio");
            DropColumn("dbo.Pacientes", "ProblemasResp");
            DropColumn("dbo.Pacientes", "ProblemasArticulaciones");
            DropColumn("dbo.Pacientes", "ProblemasEscoliosis");
            DropColumn("dbo.Pacientes", "ProblemasMeñiscos");
            DropColumn("dbo.Pacientes", "ProblemasArtrosis");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Pacientes", "ProblemasArtrosis", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pacientes", "ProblemasMeñiscos", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pacientes", "ProblemasEscoliosis", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pacientes", "ProblemasArticulaciones", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pacientes", "ProblemasResp", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pacientes", "ProblemasCardio", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pacientes", "ContMuslo", c => c.Int(nullable: false));
            AddColumn("dbo.Pacientes", "ContCintura", c => c.Int(nullable: false));
            AddColumn("dbo.Pacientes", "ContCadera", c => c.Int(nullable: false));
            AddColumn("dbo.Pacientes", "ContBrazo", c => c.Int(nullable: false));
            AlterColumn("dbo.Pacientes", "Genero", c => c.Int(nullable: false));
            AlterColumn("dbo.Comidas", "Objetivo", c => c.Int(nullable: false));
            DropColumn("dbo.Pacientes", "Antecedentes");
            DropColumn("dbo.Pacientes", "ContornoMusloEnCm");
            DropColumn("dbo.Pacientes", "ContornoCinturaEnCm");
            DropColumn("dbo.Pacientes", "ContornoCaderaEnCm");
            DropColumn("dbo.Pacientes", "ContornoBrazoEnCm");
        }
    }
}
