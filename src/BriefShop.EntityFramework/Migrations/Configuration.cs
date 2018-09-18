using System.Data.Entity.Migrations;

namespace BriefShop.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<BriefShop.EntityFramework.BriefShopDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "BriefShop";
        }

        protected override void Seed(BriefShop.EntityFramework.BriefShopDbContext context)
        {
            // This method will be called every time after migrating to the latest version.
            // You can add any seed data here...
        }
    }
}
