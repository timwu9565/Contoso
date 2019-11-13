using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Contoso.Web.Filters
{
    public class ContosoExceptionFilter: HandleErrorAttribute
    {
        public ContosoExceptionFilter()
        {

        }

        public override void OnException(ExceptionContext filterContext)
        {
            var controllerName = (string)filterContext.RouteData.Values["controller"];
            var actionName = (string)filterContext.RouteData.Values["action"];
            var model = new HandleErrorInfo(filterContext.Exception, controllerName, actionName);
            filterContext.Result = new ViewResult 
            {
                ViewName = View, 
                MasterName = Master, 
                ViewData = new ViewDataDictionary<HandleErrorInfo>(model),
                TempData = filterContext.Controller.TempData
                // every exception has these things, dont change any of these, or it might collaspes
            };
            string exceptionPath = filterContext.HttpContext.Request.Path + filterContext.HttpContext.Request.QueryString;
            // log exception information like
            // 1. Exception -> filterContext.Exception
            // 2. Inner Message -> filterContext.Exception
            // 3. DataTime -> datetime.now
            // 4. Action method & controller name
            // 5. The whole stack traces -> filterContext.Exception.StackTraces
            // 6. Eexception Path (URL)
            // 7. Log about details using Nlog(download through Nuget) to text file

            filterContext.ExceptionHandled = true;
            filterContext.HttpContext.Response.Clear();
            filterContext.HttpContext.Response.StatusCode = 500; //Server error


            base.OnException(filterContext);
        }
    }
}