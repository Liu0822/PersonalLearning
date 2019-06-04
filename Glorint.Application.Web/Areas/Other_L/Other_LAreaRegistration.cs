using System.Web.Mvc;

namespace Glorint.Application.Web.Areas.Other_L
{
    public class Other_LAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Other_L";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Other_L_default",
                "Other_L/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}