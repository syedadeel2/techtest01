using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTest01.Domain.Catalog;
using TechTest01.Repository;
using TechTest01.Services.Catalog;
using TechTest01.Shared.Exceptions;
using TechTest01.Web.Controllers;

namespace TechTest01.Tests.Web
{
    [TestClass]
    public class ProductsControllerTest
    {
        [TestMethod]
        public void ProductsController_ProductList_Test()
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

            var mockedService = new Moq.Mock<ProductService>(mockedRepo.Object);


            var controller = new ProductsController(mockedService.Object);
            var result = controller.ProductList() as ViewResult;

            Assert.IsNotNull(result.Model);
            Assert.AreEqual(2, ((Collection<Product>)result.Model).Count);

        }


        [TestMethod]
        public void ProductsController_ProductList_Empty_Test()
        {
            var mockedRepo = new Moq.Mock<IRepository<Product>>();
            mockedRepo.Setup(m => m.GetEntities()).Returns(new Collection<Product>{ });

            var mockedService = new Moq.Mock<ProductService>(mockedRepo.Object);


            var controller = new ProductsController(mockedService.Object);
            var result = controller.ProductList() as ViewResult;

            Assert.IsNotNull(result.Model);
            Assert.AreEqual(0, ((Collection<Product>)result.Model).Count);

        }

        [TestMethod]
        public void ProductsController_GetProducts_Test()
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

            var mockedService = new Moq.Mock<ProductService>(mockedRepo.Object);


            var controller = new ProductsController(mockedService.Object);
            var result = controller.All() as JsonResult;

            Assert.IsNotNull(result.Data);
            Assert.AreEqual(2, ((Collection<Product>)result.Data).Count);

        }

        [TestMethod]
        public void ProductsController_GetProducts_Empty_Test()
        {
            var mockedRepo = new Moq.Mock<IRepository<Product>>();
            mockedRepo.Setup(m => m.GetEntities()).Returns(new Collection<Product> {});

            var mockedService = new Moq.Mock<ProductService>(mockedRepo.Object);


            var controller = new ProductsController(mockedService.Object);
            var result = controller.All() as JsonResult;

            Assert.IsNotNull(result.Data);
            Assert.AreEqual(0, ((Collection<Product>)result.Data).Count);

        }
    }
}
