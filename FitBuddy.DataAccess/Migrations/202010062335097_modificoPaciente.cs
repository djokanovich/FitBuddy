namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modificoPaciente : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pacientes", "Huevo", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pacientes", "Tomate", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pacientes", "Cerdo", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pacientes", "Pollo", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pacientes", "Vaca", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pacientes", "Pescado", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pacientes", "Mariscos", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pacientes", "Leche", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pacientes", "FrutosSecos", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pacientes", "Queso", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pacientes", "Tacc", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pacientes", "Fructuosa", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pacientes", "HojasVerdes", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pacientes", "Soja", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pacientes", "FrutasRojas", c => c.Boolean(nullable: false));
            DropColumn("dbo.Pacientes", "AlergHuevo");
            DropColumn("dbo.Pacientes", "AlergLacteos");
            DropColumn("dbo.Pacientes", "AlergMariscos");
            DropColumn("dbo.Pacientes", "AlergSecos");
            DropColumn("dbo.Pacientes", "AlergTomates");
            DropColumn("dbo.Pacientes", "Celiaco");
            DropColumn("dbo.Pacientes", "Vegano");
            DropColumn("dbo.Pacientes", "Vegetariano");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Pacientes", "Vegetariano", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pacientes", "Vegano", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pacientes", "Celiaco", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pacientes", "AlergTomates", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pacientes", "AlergSecos", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pacientes", "AlergMariscos", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pacientes", "AlergLacteos", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pacientes", "AlergHuevo", c => c.Boolean(nullable: false));
            DropColumn("dbo.Pacientes", "FrutasRojas");
            DropColumn("dbo.Pacientes", "Soja");
            DropColumn("dbo.Pacientes", "HojasVerdes");
            DropColumn("dbo.Pacientes", "Fructuosa");
            DropColumn("dbo.Pacientes", "Tacc");
            DropColumn("dbo.Pacientes", "Queso");
            DropColumn("dbo.Pacientes", "FrutosSecos");
            DropColumn("dbo.Pacientes", "Leche");
            DropColumn("dbo.Pacientes", "Mariscos");
            DropColumn("dbo.Pacientes", "Pescado");
            DropColumn("dbo.Pacientes", "Vaca");
            DropColumn("dbo.Pacientes", "Pollo");
            DropColumn("dbo.Pacientes", "Cerdo");
            DropColumn("dbo.Pacientes", "Tomate");
            DropColumn("dbo.Pacientes", "Huevo");
        }
    }
}
