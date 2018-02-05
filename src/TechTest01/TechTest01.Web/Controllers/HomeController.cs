using System;
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
            return View();
        }
    }
}