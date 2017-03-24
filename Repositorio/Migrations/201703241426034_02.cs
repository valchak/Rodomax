namespace Repositorio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _02 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.material_saida_produtos", "CustoUnitario", c => c.Double(nullable: true));
        }
        
        public override void Down()
        {
            DropColumn("dbo.material_saida_produtos", "CustoUnitario");
        }
    }
}
