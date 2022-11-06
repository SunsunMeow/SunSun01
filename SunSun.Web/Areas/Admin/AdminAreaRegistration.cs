using System.Web.Mvc;

namespace SunSun.Web.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
               name: "Admin_default",
               url: "Admin/{controller}/{action}/{id}",
               defaults: new { controller = "AccAdmin", action = "Singin", id = UrlParameter.Optional }
            );
        }
    }
}