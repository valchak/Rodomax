namespace Repositorio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _07 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.despesa_detalhe", "Quantidade", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.despesa_detalhe", "Quantidade", c => c.Int(nullable: false));
        }
    }
}
