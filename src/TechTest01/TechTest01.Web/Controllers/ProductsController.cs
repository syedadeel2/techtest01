using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TechTest01.Services.Catalog;

namespace TechTest01.Web.Controllers
{
    public class ProductsController : Controller
    {
        private IProductService _productService;

        public ProductsController(IProductService productService)
        {
            this._productService = productService;
        }


        // GET: Products
        public ActionResult ProductList()
        {
            // Get All Products
            var products = _productService.GetProducts();

            var model = products;

            return View(model);
        }
    }
}