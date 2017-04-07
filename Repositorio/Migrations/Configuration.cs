namespace Repositorio.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Repositorio.ContextoDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            //SetSqlGenerator("MySql.Data.MySqlClient", new MySql.Data.Entity.MySqlMigrationSqlGenerator());

            //DbConfiguration.SetConfiguration(new MySql.Data.Entity.MySqlEFConfiguration());
            //SetHistoryContextFactory(MySql.Data.Entity.MySqlProviderInvariantName.ProviderName, (connection, schema) => new MySql.Data.Entity.MySqlHistoryContext(connection, schema));
            SetSqlGenerator(MySql.Data.Entity.MySqlProviderInvariantName.ProviderName, new MySql.Data.Entity.MySqlMigrationSqlGenerator());
        }

        protected override void Seed(Repositorio.ContextoDB context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
           
        }
    }
}
