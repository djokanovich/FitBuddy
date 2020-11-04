namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AgregarEntidadHistorialPaciente : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.ComposiciónAlimento", newName: "ComposiciónAlimentos");
            CreateTable(
                "dbo.Médicos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        DirecciónConsultorio = c.String(),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        Teléfono = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.HistorialPacientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FechaRegistro = c.DateTime(nullable: false, storeType: "date"),
                        AlturaEnCm = c.Int(nullable: false),
                        PesoEnKg = c.Single(nullable: false),
                        ContornoBrazoEnCm = c.Int(nullable: false),
                        ContornoCaderaEnCm = c.Int(nullable: false),
                        ContornoCinturaEnCm = c.Int(nullable: false),
                        ContornoMusloEnCm = c.Int(nullable: false),
                        PacienteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pacientes", t => t.PacienteId, cascadeDelete: true)
                .Index(t => t.PacienteId);
            
            AddColumn("dbo.Pacientes", "FechaNacimiento", c => c.DateTime(nullable: false, storeType: "date"));
            AddColumn("dbo.Pacientes", "Género", c => c.Byte(nullable: false));
            AddColumn("dbo.Pacientes", "DisposiciónDiariaHoras", c => c.Int(nullable: false));
            AddColumn("dbo.Pacientes", "DisposiciónSemanalDias", c => c.Int(nullable: false));
            DropColumn("dbo.Pacientes", "Altura");
            DropColumn("dbo.Pacientes", "Edad");
            DropColumn("dbo.Pacientes", "ContornoBrazoEnCm");
            DropColumn("dbo.Pacientes", "ContornoCaderaEnCm");
            DropColumn("dbo.Pacientes", "ContornoCinturaEnCm");
            DropColumn("dbo.Pacientes", "ContornoMusloEnCm");
            DropColumn("dbo.Pacientes", "Objetivo");
            DropColumn("dbo.Pacientes", "Peso");
            DropColumn("dbo.Pacientes", "FechaRegistroPerfil");
            DropColumn("dbo.Pacientes", "Genero");
            DropColumn("dbo.Pacientes", "DisposicionDiariaHoras");
            DropColumn("dbo.Pacientes", "DisposicionSemanalDias");
            DropTable("dbo.Medicos");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Medicos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        DireccionConsultorio = c.String(),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        Telefono = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Pacientes", "DisposicionSemanalDias", c => c.Int(nullable: false));
            AddColumn("dbo.Pacientes", "DisposicionDiariaHoras", c => c.Int(nullable: false));
            AddColumn("dbo.Pacientes", "Genero", c => c.Byte(nullable: false));
            AddColumn("dbo.Pacientes", "FechaRegistroPerfil", c => c.DateTime(nullable: false));
            AddColumn("dbo.Pacientes", "Peso", c => c.Int(nullable: false));
            AddColumn("dbo.Pacientes", "Objetivo", c => c.Int(nullable: false));
            AddColumn("dbo.Pacientes", "ContornoMusloEnCm", c => c.Int(nullable: false));
            AddColumn("dbo.Pacientes", "ContornoCinturaEnCm", c => c.Int(nullable: false));
            AddColumn("dbo.Pacientes", "ContornoCaderaEnCm", c => c.Int(nullable: false));
            AddColumn("dbo.Pacientes", "ContornoBrazoEnCm", c => c.Int(nullable: false));
            AddColumn("dbo.Pacientes", "Edad", c => c.Int(nullable: false));
            AddColumn("dbo.Pacientes", "Altura", c => c.Int(nullable: false));
            DropForeignKey("dbo.HistorialPacientes", "PacienteId", "dbo.Pacientes");
            DropIndex("dbo.HistorialPacientes", new[] { "PacienteId" });
            DropColumn("dbo.Pacientes", "DisposiciónSemanalDias");
            DropColumn("dbo.Pacientes", "DisposiciónDiariaHoras");
            DropColumn("dbo.Pacientes", "Género");
            DropColumn("dbo.Pacientes", "FechaNacimiento");
            DropTable("dbo.HistorialPacientes");
            DropTable("dbo.Médicos");
            RenameTable(name: "dbo.ComposiciónAlimentos", newName: "ComposiciónAlimento");
        }
    }
}
