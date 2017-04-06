namespace Repositorio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _08 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.nota_entrada_itens", "TipoProduto", c => c.String(maxLength: 1, storeType: "nvarchar"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.nota_entrada_itens", "TipoProduto");
        }
    }
}
