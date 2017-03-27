namespace Repositorio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _03 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.estoque_movimento", "MaterialSaida_Id", c => c.Int());
            CreateIndex("dbo.estoque_movimento", "MaterialSaida_Id");
            AddForeignKey("dbo.estoque_movimento", "MaterialSaida_Id", "dbo.material_saida_produtos", "Id");
            DropColumn("dbo.estoque_movimento", "Documento");
        }
        
        public override void Down()
        {
            AddColumn("dbo.estoque_movimento", "Documento", c => c.String(maxLength: 255, storeType: "nvarchar"));
            DropForeignKey("dbo.estoque_movimento", "MaterialSaida_Id", "dbo.material_saida_produtos");
            DropIndex("dbo.estoque_movimento", new[] { "MaterialSaida_Id" });
            DropColumn("dbo.estoque_movimento", "MaterialSaida_Id");
        }
    }
}
