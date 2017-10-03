using System.Web;
using System.Web.Mvc;

namespace LTWeb15CTH12Advanced
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
