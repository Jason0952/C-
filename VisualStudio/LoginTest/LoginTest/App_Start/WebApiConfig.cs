using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace LoginTest
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API 設定和服務

            // Web API 路由
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
               name: "ActionApi",
               routeTemplate: "actionapi/MicrosoftLogin/{action}",
               defaults: new { action = RouteParameter.Optional }
            );
        }
    }
}
