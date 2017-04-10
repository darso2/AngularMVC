using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication3
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapRoute(
                name: "default2",
                url: "rad",
                defaults: new { controller = "Radical", action = "extra", id = UrlParameter.Optional }
              );

            routes.MapRoute(
                name: "default",
                url: "home2",
                defaults: new { controller = "Hello", action = "rack", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Courses",
                url: "Courses",
                defaults: new { controller = "Courses", action = "Index", id = UrlParameter.Optional }
            );

        }
    }
}
