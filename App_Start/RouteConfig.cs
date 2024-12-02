using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DoanCN_Khang_Nam_Duy
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "TinTuyenDung",
                url: "tin-tuyen-dung/{TieuDeTTD}-{id}",
                defaults: new { controller = "Recruitment", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "DoanCN_Khang_Nam_Duy.Controllers" }
            );

            routes.MapRoute(
                name: "NhaTuyenDung_company",
                url: "cong-ty/{TieuDe}-{id}",
                defaults: new { controller = "Employer", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "DoanCN_Khang_Nam_Duy.Controllers" }
            );

            routes.MapRoute(
                name: "GoiYViec",
                url: "viec-lam-phu-hop",
                defaults: new { controller = "Recruitment", action = "PhuHop", id = UrlParameter.Optional },
                namespaces: new[] { "DoanCN_Khang_Nam_Duy.Controllers" }
            );

            routes.MapRoute(
                name: "BaiViet",
                url: "bai-viet/{TieuDe}-{id}",
                defaults: new { controller = "Home", action = "BaiViet", id = UrlParameter.Optional },
                namespaces: new[] { "DoanCN_Khang_Nam_Duy.Controllers" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "DoanCN_Khang_Nam_Duy.Controllers" }
            );           
        }
    }
}
