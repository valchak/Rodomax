namespace Repositorio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _04 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.despesa_tipo", "OutraOperadora", c => c.String(maxLength: 3, storeType: "nvarchar"));
            AddColumn("dbo.despesa_tipo", "Situacao", c => c.String(maxLength: 1, storeType: "nvarchar"));
            AddColumn("dbo.despesa_tipo", "Fornecedor_Id", c => c.Int());
            CreateIndex("dbo.despesa_tipo", "Fornecedor_Id");
            AddForeignKey("dbo.despesa_tipo", "Fornecedor_Id", "dbo.fornecedor", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.despesa_tipo", "Fornecedor_Id", "dbo.fornecedor");
            DropIndex("dbo.despesa_tipo", new[] { "Fornecedor_Id" });
            DropColumn("dbo.despesa_tipo", "Fornecedor_Id");
            DropColumn("dbo.despesa_tipo", "Situacao");
            DropColumn("dbo.despesa_tipo", "OutraOperadora");
        }
    }
}
