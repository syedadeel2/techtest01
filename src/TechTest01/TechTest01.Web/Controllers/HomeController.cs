﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TechTest01.Services.Catalog;

namespace TechTest01.Web.Controllers
{
    public class HomeController : Controller
    {
        private IProductService _productService;

        public HomeController(IProductService productService)
        {
            this._productService = productService;
        }

        // GET: Home
        public ActionResult Index()
        {
            // Get All Products
            var products = _productService.GetProducts();

            // Create Random Onbject
           var rand = new Random();

            // Randomize the list
            var model = products.OrderBy(x => rand.Next()).Take(2).ToList();

            return View(model);
        }
    }
}