using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Aperture_Lab
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Lab", action = "Welcome", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Route2",
                url: "{controller}/{action}/{age}/{id}",
                defaults: new { controller = "Lab", action = "Welcome", id = UrlParameter.Optional }
            );

        }
    }
}
