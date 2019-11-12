using System.Web.Mvc;

namespace Sam.Feature.MyButton.Areas.MyButton
{
    public class MyButtonAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "MyButton";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "MyButton_default",
                "MyButton/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}