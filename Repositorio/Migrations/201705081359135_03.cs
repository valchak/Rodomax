namespace Repositorio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _03 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.despesa_detalhe", "TelefoneLinha_Linha", "dbo.telefone_linha");
            DropIndex("dbo.despesa_detalhe", new[] { "TelefoneLinha_Linha" });
            RenameColumn(table: "dbo.despesa_detalhe", name: "TelefoneLinha_Linha", newName: "TelefoneLinha_Id");
            DropPrimaryKey("dbo.telefone_linha");
            AddColumn("dbo.telefone_linha", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.telefone_linha", "Observacao", c => c.String(unicode: false));
            AddColumn("dbo.telefone_cobranca", "Observacao", c => c.String(unicode: false));
            AlterColumn("dbo.despesa_detalhe", "TelefoneLinha_Id", c => c.Int());
            AlterColumn("dbo.telefone_linha", "Linha", c => c.String(maxLength: 255, storeType: "nvarchar"));
            AddPrimaryKey("dbo.telefone_linha", "Id");
            CreateIndex("dbo.despesa_detalhe", "TelefoneLinha_Id");
            AddForeignKey("dbo.despesa_detalhe", "TelefoneLinha_Id", "dbo.telefone_linha", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.despesa_detalhe", "TelefoneLinha_Id", "dbo.telefone_linha");
            DropIndex("dbo.despesa_detalhe", new[] { "TelefoneLinha_Id" });
            DropPrimaryKey("dbo.telefone_linha");
            AlterColumn("dbo.telefone_linha", "Linha", c => c.String(nullable: false, maxLength: 255, storeType: "nvarchar"));
            AlterColumn("dbo.despesa_detalhe", "TelefoneLinha_Id", c => c.String(maxLength: 255, storeType: "nvarchar"));
            DropColumn("dbo.telefone_cobranca", "Observacao");
            DropColumn("dbo.telefone_linha", "Observacao");
            DropColumn("dbo.telefone_linha", "Id");
            AddPrimaryKey("dbo.telefone_linha", "Linha");
            RenameColumn(table: "dbo.despesa_detalhe", name: "TelefoneLinha_Id", newName: "TelefoneLinha_Linha");
            CreateIndex("dbo.despesa_detalhe", "TelefoneLinha_Linha");
            AddForeignKey("dbo.despesa_detalhe", "TelefoneLinha_Linha", "dbo.telefone_linha", "Linha");
        }
    }
}
