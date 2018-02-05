namespace TechTest01.Repository.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TechTest01.Domain.Catalog;

    internal sealed class Configuration : DbMigrationsConfiguration<TechTest01.Repository.Contexts.ProductsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TechTest01.Repository.Contexts.ProductsContext context)
        {
            
            // Insert or Update Dummy data
            context.Products.AddOrUpdate(
                new Product { Name = "HP Laptop", Description = "Core i7 HP Laptop", ImageUrl = "http://ssl-product-images.www8-hp.com/digmedialib/prodimg/lowres/c05474585.png", Price = 4000, Slug = "core-i7-hp-laptop" },
                new Product { Name = "DELL Laptop", Description = "Core i5 DELL Laptop", ImageUrl = "http://i.dell.com/sites/imagecontent/products/PublishingImages/xps-15-9560-laptop/laptop-xps-15-pdp-polaris-10.jpg", Price = 2500, Slug = "core-i5-dell-laptop" },
                new Product { Name = "Nike Shoes", Description = "Nike Sport Shoes", ImageUrl = "http://imshopping.rediff.com/imgshop/800-1280/shopping/pixs/21612/n/nike-airmax-2017-014_2._imported-nike-airmax-2017-red-mens-sports-shoes.jpg", Price = 12000, Slug = "nike-sports-shoes" },
                new Product { Name = "Adeel's AutoPilot Device", Description = "Adeel's AutoPilot Device which helps to covert any car into automatic driving", ImageUrl = "https://cycling.today/wp-content/uploads/2017/06/Tesla-self-driving.jpg", Price = 334000, Slug = "adeels-autopilot-device" }
                );

        }
    }
}
