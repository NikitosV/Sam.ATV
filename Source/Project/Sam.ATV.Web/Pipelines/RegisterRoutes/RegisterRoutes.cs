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
        }
    }
}