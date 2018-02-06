using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTest01.Domain.Catalog;
using TechTest01.Repository;
using TechTest01.Services.Catalog;
using TechTest01.Web.Controllers;

namespace TechTest01.Tests.Web
{
    [TestClass]
    public class AngularControllerTest
    {
        [TestMethod]
        public void AngularControllerView_Test()
        {

             var controller = new AngularController();
            var result = controller.Index() as ViewResult;

            Assert.IsTrue(true);

        }
    }
}
