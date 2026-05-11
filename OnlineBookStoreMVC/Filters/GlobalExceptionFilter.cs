using Microsoft.AspNetCore.Mvc.Filters;

namespace OnlineBookStore.Filters
{
    public class GlobalExceptionFilter :
        ExceptionFilterAttribute
    {
        public override void OnException(
            ExceptionContext context)
        {
            Console.WriteLine(context.Exception.Message);
        }
    }
}