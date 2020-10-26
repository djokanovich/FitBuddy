namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SimplificarAlergiasEnPaciente : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Comidas", "Contiene", c => c.Int(nullable: false));
            AddColumn("dbo.Pacientes", "Alergias", c => c.Int(nullable: false));
            DropColumn("dbo.Comidas", "TipoAlimento");
            DropColumn("dbo.Pacientes", "Huevo");
            DropColumn("dbo.Pacientes", "Tomate");
            DropColumn("dbo.Pacientes", "Cerdo");
            DropColumn("dbo.Pacientes", "Pollo");
            DropColumn("dbo.Pacientes", "Vaca");
            DropColumn("dbo.Pacientes", "Pescado");
            DropColumn("dbo.Pacientes", "Mariscos");
            DropColumn("dbo.Pacientes", "Leche");
            DropColumn("dbo.Pacientes", "FrutosSecos");
            DropColumn("dbo.Pacientes", "Queso");
            DropColumn("dbo.Pacientes", "Tacc");
            DropColumn("dbo.Pacientes", "Fructuosa");
            DropColumn("dbo.Pacientes", "HojasVerdes");
            DropColumn("dbo.Pacientes", "Soja");
            DropColumn("dbo.Pacientes", "FrutasRojas");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Pacientes", "FrutasRojas", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pacientes", "Soja", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pacientes", "HojasVerdes", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pacientes", "Fructuosa", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pacientes", "Tacc", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pacientes", "Queso", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pacientes", "FrutosSecos", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pacientes", "Leche", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pacientes", "Mariscos", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pacientes", "Pescado", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pacientes", "Vaca", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pacientes", "Pollo", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pacientes", "Cerdo", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pacientes", "Tomate", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pacientes", "Huevo", c => c.Boolean(nullable: false));
            AddColumn("dbo.Comidas", "TipoAlimento", c => c.Int(nullable: false));
            DropColumn("dbo.Pacientes", "Alergias");
            DropColumn("dbo.Comidas", "Contiene");
        }
    }
}
