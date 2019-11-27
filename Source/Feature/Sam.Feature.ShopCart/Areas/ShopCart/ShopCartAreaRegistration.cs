using System.Web.Mvc;

namespace Sam.Feature.ShopCart.Areas.ShopCart
{
    public class ShopCartAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "ShopCart";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "ShopCart_default",
                "ShopCart/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}