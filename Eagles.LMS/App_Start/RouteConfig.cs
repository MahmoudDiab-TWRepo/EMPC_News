﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Eagles.LMS
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            //routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            //routes.MapMvcAttributeRoutes();
            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            //);
            routes.MapMvcAttributeRoutes();
            routes.MapRoute(
"Default",
"{controller}/{action}/{id}",
new { controller = "Home", action = "Index", id = UrlParameter.Optional },
new[] { "Eagles.LMS.Controllers" }
);
        }
    }
}
