using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using Microsoft.Owin.Security.OAuth;
using Newtonsoft.Json.Serialization;
using System.Web.Mvc;

namespace WebApiRestful
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            // Configure Web API to use only bearer token authentication.
            config.SuppressDefaultHostAuthentication();
            config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
               name: "WebApiHome",
               routeTemplate: "MyRestfullApp/Cotizacion/Moneda/{currency}",
               defaults: new { controller = "WebApiHome", action = "GetQuotation", id = UrlParameter.Optional }
           );

            config.Routes.MapHttpRoute(
               name: "WebApiHomeUsers",
               routeTemplate: "MyRestfullApp/Users/GetUsers",
               defaults: new { controller = "WebApiHome", action = "GetUsers", id = UrlParameter.Optional }
            );

            config.Routes.MapHttpRoute(
              name: "WebApiHomeCreateUser",
              routeTemplate: "MyRestfullApp/Users/CreateUser",
              defaults: new { controller = "WebApiHome", action = "CreateUser", id = UrlParameter.Optional }
           );

            config.Routes.MapHttpRoute(
             name: "WebApiHomeUpdateUser",
             routeTemplate: "MyRestfullApp/Users/UpdateUser/{id}",
             defaults: new { controller = "WebApiHome", action = "UpdateUser", id = UrlParameter.Optional }
          );

            config.Routes.MapHttpRoute(
            name: "WebApiHomeDeleteUser",
            routeTemplate: "MyRestfullApp/Users/DeleteUser/{id}",
            defaults: new { controller = "WebApiHome", action = "DeleteUser", id = UrlParameter.Optional }
         );
        }
    }
}
