using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;

namespace AdminBlog2.Filter
{
    public class UserFilter : ActionFilterAttribute  // Kalıtım yapıyoruz
    {
        public override void OnActionExecuting(ActionExecutingContext context){
            int? userId = context.HttpContext.Session.GetInt32("id");  // Home Kontrollerdeki  .HttpContext.Session işlemine göre yapıyoruz.

            if(!userId.HasValue){   // HasValue bir değer varsa
                context.Result = new RedirectToRouteResult(
                    new RouteValueDictionary
                    {
                        {"action" ,"Index"},
                        {"controller","Home"}
                    }
                );
            }
        }

    }
}