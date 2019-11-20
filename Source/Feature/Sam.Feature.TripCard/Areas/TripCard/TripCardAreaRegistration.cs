using System.Web.Mvc;

namespace Sam.Feature.TripCard.Areas.TripCard
{
    public class TripCardAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "TripCard";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "TripCard_default",
                "TripCard/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}