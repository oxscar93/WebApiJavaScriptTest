using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApiRestful
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "MyRestfullApp/Cotizacion/Moneda/{currency}",
                defaults: new { controller = "WebApiHome", action = "GetQuotation", id = UrlParameter.Optional}
            );
        }
    }
}
