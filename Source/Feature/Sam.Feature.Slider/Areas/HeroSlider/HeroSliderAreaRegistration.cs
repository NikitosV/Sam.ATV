using System.Web.Mvc;

namespace Sam.Feature.Slider.Areas.HeroSlider
{
    public class HeroSliderAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "HeroSlider";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "HeroSlider_default",
                "HeroSlider/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}