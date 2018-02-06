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
    public class ProductControllerTest
    {
        [TestMethod]
        public void ProductController_ViewProduct_Test()
        {
            var mockedRepo = new Moq.Mock<IRepository<Product>>();
            mockedRepo.Setup(m => m.GetEntityByProperty("Slug", "core-i7-hp-laptop")).Returns(new Product
            {
                Id = 1,
                Name = "HP Laptop",
                Description = "Core i7 HP Laptop",
                ImageUrl = "http://ssl-product-images.www8-hp.com/digmedialib/prodimg/lowres/c05474585.png",
                Price = 4000,
                Slug = "core-i7-hp-laptop"
            }

        );

            var mockedService = new Moq.Mock<ProductService>(mockedRepo.Object);


            var controller = new ProductController(mockedService.Object);
            var result = controller.ViewProduct("core-i7-hp-laptop") as ViewResult;

            Assert.IsNotNull(result.Model);
            Assert.AreEqual("core-i7-hp-laptop", ((Product)result.Model).Slug);

        }

        [TestMethod]
        [ExpectedException(typeof(RecordNotFoundException))]
        public void ProductController_ViewProduct_NotFound_Test()
        {
            var mockedRepo = new Moq.Mock<IRepository<Product>>();
            mockedRepo.Setup(m => m.GetEntityByProperty("Slug", "core-i7-hp-laptop")).Returns(new Product
            {
                Id = 1,
                Name = "HP Laptop",
                Description = "Core i7 HP Laptop",
                ImageUrl = "http://ssl-product-images.www8-hp.com/digmedialib/prodimg/lowres/c05474585.png",
                Price = 4000,
                Slug = "core-i7-hp-laptop"
            }

        );

            var mockedService = new Moq.Mock<ProductService>(mockedRepo.Object);


            var controller = new ProductController(mockedService.Object);
            var result = controller.ViewProduct("core-i7-hp-laptop2") as ViewResult;

        }

        [TestMethod]
        public void ProductController_ViewProduct_EmptySlug_Test()
        {
            var mockedRepo = new Moq.Mock<IRepository<Product>>();
            mockedRepo.Setup(m => m.GetEntityByProperty("Slug", "core-i7-hp-laptop")).Returns(new Product
            {
                Id = 1,
                Name = "HP Laptop",
                Description = "Core i7 HP Laptop",
                ImageUrl = "http://ssl-product-images.www8-hp.com/digmedialib/prodimg/lowres/c05474585.png",
                Price = 4000,
                Slug = "core-i7-hp-laptop"
            }

        );

            var mockedService = new Moq.Mock<ProductService>(mockedRepo.Object);


            var controller = new ProductController(mockedService.Object);
            var result = controller.ViewProduct("") as ViewResult;

            Assert.IsNull(result);

        }

        [TestMethod]
        public void ProductController_GetProduct_Test()
        {
            var mockedRepo = new Moq.Mock<IRepository<Product>>();
            mockedRepo.Setup(m => m.GetEntityByProperty("Slug", "core-i7-hp-laptop")).Returns(new Product
            {
                Id = 1,
                Name = "HP Laptop",
                Description = "Core i7 HP Laptop",
                ImageUrl = "http://ssl-product-images.www8-hp.com/digmedialib/prodimg/lowres/c05474585.png",
                Price = 4000,
                Slug = "core-i7-hp-laptop"
            }

        );

            var mockedService = new Moq.Mock<ProductService>(mockedRepo.Object);


            var controller = new ProductController(mockedService.Object);
            var result = controller.GetProduct("core-i7-hp-laptop") as JsonResult;

            Assert.IsNotNull(result.Data);

        }

        [TestMethod]
        public void ProductController_GetProduct_EmptySlug_Test()
        {
            var mockedRepo = new Moq.Mock<IRepository<Product>>();
            mockedRepo.Setup(m => m.GetEntityByProperty("Slug", "core-i7-hp-laptop")).Returns(new Product
            {
                Id = 1,
                Name = "HP Laptop",
                Description = "Core i7 HP Laptop",
                ImageUrl = "http://ssl-product-images.www8-hp.com/digmedialib/prodimg/lowres/c05474585.png",
                Price = 4000,
                Slug = "core-i7-hp-laptop"
            }

        );

            var mockedService = new Moq.Mock<ProductService>(mockedRepo.Object);


            var controller = new ProductController(mockedService.Object);
            var result = controller.GetProduct("") as JsonResult;

            Assert.IsNotNull(result.Data);
            Assert.AreEqual("Slug is required", result.Data.GetType().GetProperty("error").GetValue(result.Data).ToString());

        }
    }
}
