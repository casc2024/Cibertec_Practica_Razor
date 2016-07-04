using System.Diagnostics;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebDeveloper.ActionFilters
{
    public class LogActionFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {

            ResultDebug("OnActionExecuting", filterContext.RouteData);
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            ResultDebug("OnActionExecuted", filterContext.RouteData);
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {

            ResultDebug("ResultExecutedContext", filterContext.RouteData);
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {

            ResultDebug("ResultExecutingContext", filterContext.RouteData);
        }

        private static void ResultDebug(string nameResult, RouteData routeData)
        {
            Debug.WriteLine($"{nameResult} controller : {routeData.Values["controller"]} action: {routeData.Values["action"]}", "Action Filter Log");
        }
    }
}