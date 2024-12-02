using System.Web.Mvc;

namespace DoanCN_Khang_Nam_Duy.Areas.Admin
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
                "Admin",
                "Admin/{controller}/{action}/{id}",
                new { areas = "admin", action = "Index", id = UrlParameter.Optional },
                new[] { "DoanCN_Khang_Nam_Duy.Areas.Admin.Controllers" }
            );
        }
    }
}