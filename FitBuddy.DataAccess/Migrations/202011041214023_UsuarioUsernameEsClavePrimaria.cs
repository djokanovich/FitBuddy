namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UsuarioUsernameEsClavePrimaria : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Pacientes", "UsuarioId", "dbo.Usuarios");
            DropIndex("dbo.Pacientes", new[] { "UsuarioId" });
            DropPrimaryKey("dbo.Usuarios");
            AddColumn("dbo.Pacientes", "Usuario_Id", c => c.Int());
            AddColumn("dbo.Pacientes", "Usuario_Username", c => c.String(maxLength: 128));
            AlterColumn("dbo.Usuarios", "Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Usuarios", "Username", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Usuarios", new[] { "Id", "Username" });
            CreateIndex("dbo.Pacientes", new[] { "Usuario_Id", "Usuario_Username" });
            AddForeignKey("dbo.Pacientes", new[] { "Usuario_Id", "Usuario_Username" }, "dbo.Usuarios", new[] { "Id", "Username" });
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pacientes", new[] { "Usuario_Id", "Usuario_Username" }, "dbo.Usuarios");
            DropIndex("dbo.Pacientes", new[] { "Usuario_Id", "Usuario_Username" });
            DropPrimaryKey("dbo.Usuarios");
            AlterColumn("dbo.Usuarios", "Username", c => c.String());
            AlterColumn("dbo.Usuarios", "Id", c => c.Int(nullable: false, identity: true));
            DropColumn("dbo.Pacientes", "Usuario_Username");
            DropColumn("dbo.Pacientes", "Usuario_Id");
            AddPrimaryKey("dbo.Usuarios", "Id");
            CreateIndex("dbo.Pacientes", "UsuarioId");
            AddForeignKey("dbo.Pacientes", "UsuarioId", "dbo.Usuarios", "Id", cascadeDelete: true);
        }
    }
}
