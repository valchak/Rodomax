namespace Repositorio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _06 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.funcionario", "Funcao", c => c.String(maxLength: 255, storeType: "nvarchar"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.funcionario", "Funcao");
        }
    }
}
