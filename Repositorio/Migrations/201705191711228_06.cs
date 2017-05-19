namespace Repositorio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _06 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.despesa_detalhe", "OutraOperadora", c => c.String(maxLength: 1, storeType: "nvarchar"));
            DropColumn("dbo.despesa", "OutraOperadora");
        }
        
        public override void Down()
        {
            AddColumn("dbo.despesa", "OutraOperadora", c => c.String(maxLength: 1, storeType: "nvarchar"));
            DropColumn("dbo.despesa_detalhe", "OutraOperadora");
        }
    }
}
