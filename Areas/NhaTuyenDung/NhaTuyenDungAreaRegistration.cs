using System.Web.Mvc;

namespace DoanCN_Khang_Nam_Duy.Areas.NhaTuyenDung
{
    public class NhaTuyenDungAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "NhaTuyenDung";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "NhaTuyenDung",
                "nha-tuyen-dung/{controller}/{action}/{id}",
                new { controller = "Login", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}