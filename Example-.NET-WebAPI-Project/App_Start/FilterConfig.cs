using System.Web;
using System.Web.Mvc;

namespace Example_.NET_WebAPI_Project
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
