namespace Repositorio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _04 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.secur_perfil",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.secur_form",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomeFormulario = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.secur_acesso",
                c => new
                    {
                        SecurForm_Id = c.Int(nullable: false),
                        SecurPerfil_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.SecurForm_Id, t.SecurPerfil_Id })
                .ForeignKey("dbo.secur_form", t => t.SecurForm_Id, cascadeDelete: true)
                .ForeignKey("dbo.secur_perfil", t => t.SecurPerfil_Id, cascadeDelete: true)
                .Index(t => t.SecurForm_Id)
                .Index(t => t.SecurPerfil_Id);
            
            AddColumn("dbo.usuario", "Perfil_Id", c => c.Int());
            CreateIndex("dbo.usuario", "Perfil_Id");
            AddForeignKey("dbo.usuario", "Perfil_Id", "dbo.secur_perfil", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.usuario", "Perfil_Id", "dbo.secur_perfil");
            DropForeignKey("dbo.secur_acesso", "SecurPerfil_Id", "dbo.secur_perfil");
            DropForeignKey("dbo.secur_acesso", "SecurForm_Id", "dbo.secur_form");
            DropIndex("dbo.secur_acesso", new[] { "SecurPerfil_Id" });
            DropIndex("dbo.secur_acesso", new[] { "SecurForm_Id" });
            DropIndex("dbo.usuario", new[] { "Perfil_Id" });
            DropColumn("dbo.usuario", "Perfil_Id");
            DropTable("dbo.secur_acesso");
            DropTable("dbo.secur_form");
            DropTable("dbo.secur_perfil");
        }
    }
}
