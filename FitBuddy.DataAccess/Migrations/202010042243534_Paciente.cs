namespace FitBuddy.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Paciente : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pacientes", "UsuarioId", c => c.Int(nullable: false));
            AddColumn("dbo.Pacientes", "Altura", c => c.Int(nullable: false));
            AddColumn("dbo.Pacientes", "ContBrazo", c => c.Int(nullable: false));
            AddColumn("dbo.Pacientes", "ContCadera", c => c.Int(nullable: false));
            AddColumn("dbo.Pacientes", "ContCintura", c => c.Int(nullable: false));
            AddColumn("dbo.Pacientes", "ContMuslo", c => c.Int(nullable: false));
            AddColumn("dbo.Pacientes", "Objetivo", c => c.Int(nullable: false));
            AddColumn("dbo.Pacientes", "Peso", c => c.Int(nullable: false));
            AddColumn("dbo.Pacientes", "AlergHuevo", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pacientes", "AlergLacteos", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pacientes", "AlergMariscos", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pacientes", "AlergSecos", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pacientes", "AlergTomates", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pacientes", "Celiaco", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pacientes", "Vegano", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pacientes", "Vegetariano", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pacientes", "DispDiaria", c => c.Int(nullable: false));
            AddColumn("dbo.Pacientes", "DispSemanal", c => c.Int(nullable: false));
            AddColumn("dbo.Pacientes", "IdPerfilFisico", c => c.Int(nullable: false));
            AddColumn("dbo.Pacientes", "ProblemasCardio", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pacientes", "ProblemasResp", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pacientes", "ProblemasTraumat", c => c.Boolean(nullable: false));
            CreateIndex("dbo.Pacientes", "UsuarioId");
            AddForeignKey("dbo.Pacientes", "UsuarioId", "dbo.Usuarios", "Id", cascadeDelete: true);
            DropTable("dbo.PerfilDietas");
            DropTable("dbo.PerfilFisicoes");
            DropTable("dbo.PerfilPacientes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.PerfilPacientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Altura = c.Int(nullable: false),
                        ContBrazo = c.Int(nullable: false),
                        ContCadera = c.Int(nullable: false),
                        ContCintura = c.Int(nullable: false),
                        ContMuslo = c.Int(nullable: false),
                        Objetivo = c.Int(nullable: false),
                        Peso = c.Int(nullable: false),
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
                "dbo.PerfilDietas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AlergHuevo = c.Boolean(nullable: false),
                        AlergLacteos = c.Boolean(nullable: false),
                        AlergMariscos = c.Boolean(nullable: false),
                        AlergSecos = c.Boolean(nullable: false),
                        AlergTomates = c.Boolean(nullable: false),
                        Celiaco = c.Boolean(nullable: false),
                        Vegano = c.Boolean(nullable: false),
                        Vegetariano = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropForeignKey("dbo.Pacientes", "UsuarioId", "dbo.Usuarios");
            DropIndex("dbo.Pacientes", new[] { "UsuarioId" });
            DropColumn("dbo.Pacientes", "ProblemasTraumat");
            DropColumn("dbo.Pacientes", "ProblemasResp");
            DropColumn("dbo.Pacientes", "ProblemasCardio");
            DropColumn("dbo.Pacientes", "IdPerfilFisico");
            DropColumn("dbo.Pacientes", "DispSemanal");
            DropColumn("dbo.Pacientes", "DispDiaria");
            DropColumn("dbo.Pacientes", "Vegetariano");
            DropColumn("dbo.Pacientes", "Vegano");
            DropColumn("dbo.Pacientes", "Celiaco");
            DropColumn("dbo.Pacientes", "AlergTomates");
            DropColumn("dbo.Pacientes", "AlergSecos");
            DropColumn("dbo.Pacientes", "AlergMariscos");
            DropColumn("dbo.Pacientes", "AlergLacteos");
            DropColumn("dbo.Pacientes", "AlergHuevo");
            DropColumn("dbo.Pacientes", "Peso");
            DropColumn("dbo.Pacientes", "Objetivo");
            DropColumn("dbo.Pacientes", "ContMuslo");
            DropColumn("dbo.Pacientes", "ContCintura");
            DropColumn("dbo.Pacientes", "ContCadera");
            DropColumn("dbo.Pacientes", "ContBrazo");
            DropColumn("dbo.Pacientes", "Altura");
            DropColumn("dbo.Pacientes", "UsuarioId");
        }
    }
}
