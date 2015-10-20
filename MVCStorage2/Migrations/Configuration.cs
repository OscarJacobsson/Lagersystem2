namespace MVCStorage2.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Models;

    internal sealed class Configuration : DbMigrationsConfiguration<MVCStorage2.DataAccessLayer.StorageContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MVCStorage2.DataAccessLayer.StorageContext context)
        {

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Products.AddOrUpdate(
              p => new { p.Name, p.Description },
              new Product { Name = "Mouse", Category = "Electronics", Count = 14, Description = "Apple Magic Mouse", Price = 799.90m, Shelf = "A" },
              new Product { Name = "Keyboard", Category = "Electronics", Count = 12, Description = "Logitech Ergonomic E12x", Price = 499.90m, Shelf = "A" },
              new Product { Name = "Chair", Category = "Furniture", Count = 4, Description = "Herman Miller", Price = 3290, Shelf = "F" },
              new Product { Name = "Chair", Category = "Furniture", Count = 4, Description = "Ikea Ergonomics", Price = 1280, Shelf = "F" }
            );            
        }
    }
}
