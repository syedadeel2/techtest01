using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace TechTest01.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                   name: "Product",
                   url: "product/{*slug}",
                   defaults: new { controller = "Product", action = "ViewProduct" },
                   constraints: new { slug = ".+"}
            );


            routes.MapRoute(
                   name: "Products",
                   url: "products",
                   defaults: new { controller = "Products", action = "ProductList" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );



        }
    }
}
