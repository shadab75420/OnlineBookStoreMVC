using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace OnlineBookStore.Filters
{
    public class AuthFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(
            ActionExecutingContext context)
        {
            var user =
                context.HttpContext.Session.GetString("user");

            if (string.IsNullOrEmpty(user))
            {
                context.Result =
                    new RedirectResult("/Login");
            }
        }
    }
}