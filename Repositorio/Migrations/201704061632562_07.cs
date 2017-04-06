namespace Repositorio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _07 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.material_saida_produtos", "TipoProduto", c => c.String(maxLength: 1, storeType: "nvarchar"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.material_saida_produtos", "TipoProduto");
        }
    }
}
