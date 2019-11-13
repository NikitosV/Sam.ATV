using System.Web.Mvc;

namespace Sam.Feature.BikeCard.Areas.BikeCard
{
    public class BikeCardAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "BikeCard";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "BikeCard_default",
                "BikeCard/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}