namespace Repositorio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _05 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.secur_perfil", "Descricao", c => c.String(maxLength: 255, storeType: "nvarchar"));
            AlterColumn("dbo.secur_form", "NomeFormulario", c => c.String(maxLength: 255, storeType: "nvarchar"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.secur_form", "NomeFormulario", c => c.String(unicode: false));
            AlterColumn("dbo.secur_perfil", "Descricao", c => c.String(unicode: false));
        }
    }
}
