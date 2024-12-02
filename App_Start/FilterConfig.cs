using System.Web;
using System.Web.Mvc;

namespace DoanCN_Khang_Nam_Duy
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
