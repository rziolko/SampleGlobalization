using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SampleGlobalization
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
             name: "Root",
             url: "",
             defaults: new
             {
                 controller = "Base",
                 action = "RedirectToLang"
             }
         );

            routes.MapRoute(
                name: "Default",

                url: "{culture}/{controller}/{action}/{id}",
                defaults: new 
                    {
                    culture = "pl",
                    controller = "Home", action = "Index", id = UrlParameter.Optional 
                    }, constraints: new { culture = "pl|en" }
            );
        }
    }
}
