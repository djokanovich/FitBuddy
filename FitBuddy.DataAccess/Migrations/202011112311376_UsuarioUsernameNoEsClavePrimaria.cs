namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UsuarioUsernameNoEsClavePrimaria : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Pacientes", new[] { "Usuario_Id", "Usuario_Username" }, "dbo.Usuarios");
            DropIndex("dbo.Pacientes", new[] { "Usuario_Id", "Usuario_Username" });
            DropColumn("dbo.Pacientes", "UsuarioId");
            RenameColumn(table: "dbo.Pacientes", name: "Usuario_Id", newName: "UsuarioId");
            DropPrimaryKey("dbo.Usuarios");
            AlterColumn("dbo.Pacientes", "UsuarioId", c => c.Int(nullable: false));
            AlterColumn("dbo.Usuarios", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Usuarios", "Username", c => c.String());
            AddPrimaryKey("dbo.Usuarios", "Id");
            CreateIndex("dbo.Pacientes", "UsuarioId");
            AddForeignKey("dbo.Pacientes", "UsuarioId", "dbo.Usuarios", "Id", cascadeDelete: true);
            DropColumn("dbo.Pacientes", "Usuario_Username");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Pacientes", "Usuario_Username", c => c.String(maxLength: 128));
            DropForeignKey("dbo.Pacientes", "UsuarioId", "dbo.Usuarios");
            DropIndex("dbo.Pacientes", new[] { "UsuarioId" });
            DropPrimaryKey("dbo.Usuarios");
            AlterColumn("dbo.Usuarios", "Username", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Usuarios", "Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Pacientes", "UsuarioId", c => c.Int());
            AddPrimaryKey("dbo.Usuarios", new[] { "Id", "Username" });
            RenameColumn(table: "dbo.Pacientes", name: "UsuarioId", newName: "Usuario_Id");
            AddColumn("dbo.Pacientes", "UsuarioId", c => c.Int(nullable: false));
            CreateIndex("dbo.Pacientes", new[] { "Usuario_Id", "Usuario_Username" });
            AddForeignKey("dbo.Pacientes", new[] { "Usuario_Id", "Usuario_Username" }, "dbo.Usuarios", new[] { "Id", "Username" });
        }
    }
}
