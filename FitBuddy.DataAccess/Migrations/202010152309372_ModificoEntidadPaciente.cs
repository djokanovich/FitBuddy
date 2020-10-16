namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModificoEntidadPaciente : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pacientes", "FrecuenciaActual", c => c.Int(nullable: false));
            AddColumn("dbo.Pacientes", "DisposicionDiariaHoras", c => c.Int(nullable: false));
            AddColumn("dbo.Pacientes", "DisposicionSemanalDias", c => c.Int(nullable: false));
            AddColumn("dbo.Pacientes", "ObjetivoBuscado", c => c.Int(nullable: false));
            AddColumn("dbo.Pacientes", "ProblemasArticulaciones", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pacientes", "ProblemasEscoliosis", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pacientes", "ProblemasMeñiscos", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pacientes", "ProblemasArtrosis", c => c.Boolean(nullable: false));
            DropColumn("dbo.Pacientes", "DispDiaria");
            DropColumn("dbo.Pacientes", "DispSemanal");
            DropColumn("dbo.Pacientes", "IdPerfilFisico");
            DropColumn("dbo.Pacientes", "ProblemasTraumat");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Pacientes", "ProblemasTraumat", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pacientes", "IdPerfilFisico", c => c.Int(nullable: false));
            AddColumn("dbo.Pacientes", "DispSemanal", c => c.Int(nullable: false));
            AddColumn("dbo.Pacientes", "DispDiaria", c => c.Int(nullable: false));
            DropColumn("dbo.Pacientes", "ProblemasArtrosis");
            DropColumn("dbo.Pacientes", "ProblemasMeñiscos");
            DropColumn("dbo.Pacientes", "ProblemasEscoliosis");
            DropColumn("dbo.Pacientes", "ProblemasArticulaciones");
            DropColumn("dbo.Pacientes", "ObjetivoBuscado");
            DropColumn("dbo.Pacientes", "DisposicionSemanalDias");
            DropColumn("dbo.Pacientes", "DisposicionDiariaHoras");
            DropColumn("dbo.Pacientes", "FrecuenciaActual");
        }
    }
}
