namespace Repositorio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _02 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.patrimonio_historico", "Data", c => c.DateTime(nullable: false, precision: 0));
            AddColumn("dbo.patrimonio_historico", "Patrimonio_Id", c => c.Int());
            AddColumn("dbo.patrimonio", "Descricao", c => c.String(maxLength: 255, storeType: "nvarchar"));
            CreateIndex("dbo.patrimonio_historico", "Patrimonio_Id");
            AddForeignKey("dbo.patrimonio_historico", "Patrimonio_Id", "dbo.patrimonio", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.patrimonio_historico", "Patrimonio_Id", "dbo.patrimonio");
            DropIndex("dbo.patrimonio_historico", new[] { "Patrimonio_Id" });
            DropColumn("dbo.patrimonio", "Descricao");
            DropColumn("dbo.patrimonio_historico", "Patrimonio_Id");
            DropColumn("dbo.patrimonio_historico", "Data");
        }
    }
}
