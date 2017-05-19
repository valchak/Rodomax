namespace Repositorio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _05 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.despesa", "OutraOperadora", c => c.String(maxLength: 1, storeType: "nvarchar"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.despesa", "OutraOperadora");
        }
    }
}
