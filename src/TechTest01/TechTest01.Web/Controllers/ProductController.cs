using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TechTest01.Services.Catalog;

namespace TechTest01.Web.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            this._productService = productService;
        }

        public ActionResult ViewProduct(string slug)
        {
            // if its empty let redirect back to home page.
            if (string.IsNullOrEmpty(slug))
            {
                return Redirect("/");
            }

            var product = this._productService.GetBySlug(slug);
            var model = product;

            return View(model);
        }
    }
}