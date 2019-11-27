using Sitecore.Pipelines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Sam.ATV.Web.Pipelines.RegisterRoutes
{
    public class RegisterRoutes
    {
        public void Process(PipelineArgs args)
        {
            RouteTable.Routes.MapRoute("SubmitBikeSearch", "Search/SubmitBikeSearch", new { controller = "Search", action = "SubmitBikeSearch" });
            RouteTable.Routes.MapRoute("SubmitTripSearch", "Search/SubmitTripSearch", new { controller = "Search", action = "SubmitTripSearch" });

            RouteTable.Routes.MapRoute(name: "PRegister", url: "Account/PRegister", defaults: new { controller = "Account", action = "PRegister" });
            RouteTable.Routes.MapRoute(name: "PLogin", url: "Account/PLogin", defaults: new { controller = "Account", action = "PLogin" });
            RouteTable.Routes.MapRoute(name: "LogOut", url: "Account/LogOut", defaults: new { controller = "Account", action = "LogOut" });

            RouteTable.Routes.MapRoute(name: "AddBikeToOrder", url: "Order/AddBikeToOrder", defaults: new { controller = "Order", action = "AddBikeToOrder" });
            RouteTable.Routes.MapRoute(name: "AddSocialRev", url: "Contact/AddSocialRev", defaults: new { controller = "Contact", action = "AddSocialRev" });
        }
    }
}