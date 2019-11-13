using System.Web;
using System.Web.Mvc;
using Contoso.Web.Filters;

namespace Contoso.Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new ContosoExceptionFilter());
        }
    }
}
