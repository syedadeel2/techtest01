using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTest01.Domain.Catalog;
using TechTest01.Repository;
using TechTest01.Services.Catalog;
using TechTest01.Shared.Exceptions;

namespace TechTest01.Tests.Services
{
    [TestClass]
    public class ProductServiceTest
    {
        [TestMethod]
        public void GetProductByIdTest()
        {
            var mockedRepo = new Moq.Mock<IRepository<Product>>();
            mockedRepo.Setup(m => m.GetEntityById(1)).Returns(new Product
            {
                Id = 1,
                Name = "HP Laptop",
                Description = "Core i7 HP Laptop",
                ImageUrl = "http://ssl-product-images.www8-hp.com/digmedialib/prodimg/lowres/c05474585.png",
                Price = 4000,
                Slug = "core-i7-hp-laptop"
            });

            var productService = new ProductService(mockedRepo.Object);

            var result = productService.GetById(1);

            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Id);

        }

        [TestMethod]
        [ExpectedException(typeof(RecordNotFoundException))]
        public void GetProductById_NotFoundTest()
        {
            var mockedRepo = new Moq.Mock<IRepository<Product>>();
            mockedRepo.Setup(m => m.GetEntityById(1)).Returns<Product>(null);

            var productService = new ProductService(mockedRepo.Object);

            var result = productService.GetById(1);
        }

        [TestMethod]
        public void GetProductsTest()
        {
            var mockedRepo = new Moq.Mock<IRepository<Product>>();
            mockedRepo.Setup(m => m.GetEntities()).Returns(new Collection<Product> {

            new Product {
                Id = 1,
                Name = "HP Laptop",
                Description = "Core i7 HP Laptop",
                ImageUrl = "http://ssl-product-images.www8-hp.com/digmedialib/prodimg/lowres/c05474585.png",
                Price = 4000,
                Slug = "core-i7-hp-laptop" },

             new Product {
                 Id = 2,
                 Name = "DELL Laptop",
                 Description = "Core i5 DELL Laptop",
                 ImageUrl = "http://i.dell.com/sites/imagecontent/products/PublishingImages/xps-15-9560-laptop/laptop-xps-15-pdp-polaris-10.jpg",
                 Price = 2500,
                 Slug = "core-i5-dell-laptop" }

            });

            var productService = new ProductService(mockedRepo.Object);

            var results = productService.GetProducts();

            Assert.AreEqual(2, results.Count);
        }
    }
}
