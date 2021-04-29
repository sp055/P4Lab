namespace Z4.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Z4.KontekstEF6>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Z4.KontekstEF6";
        }

        protected override void Seed(Z4.KontekstEF6 context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
