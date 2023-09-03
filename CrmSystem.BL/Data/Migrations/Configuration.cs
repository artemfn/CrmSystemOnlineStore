namespace CrmSystem.BL.Data.Migrations
{
    using System.Data.Entity.Migrations;

    /// <summary>
    /// Implements configurations for migration operations.
    /// </summary>
    internal sealed class Configuration : DbMigrationsConfiguration<CrmContext>
    {
        /// <summary>
        /// Implements configurations settings. 
        /// </summary>
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        /// <summary>
        /// This method will be called after migrating to the latest version.
        /// You can use the DbSet<T>.AddOrUpdate() helper extension method
        /// to avoid creating duplicate seed data.
        /// </summary>
        /// <param name="context">The class that inherits DbContext.</param>
        protected override void Seed(CrmContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}