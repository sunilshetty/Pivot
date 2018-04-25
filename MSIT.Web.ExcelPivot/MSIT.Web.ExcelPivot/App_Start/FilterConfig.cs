using System.Web;
using System.Web.Mvc;

namespace MSIT.Web.ExcelPivot
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
