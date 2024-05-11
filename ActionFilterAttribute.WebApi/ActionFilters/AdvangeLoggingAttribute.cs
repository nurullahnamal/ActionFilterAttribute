using Microsoft.AspNetCore.Mvc.Filters;

namespace ActionFilterAttribute.WebApi.ActionFilters
{
    [AttributeUsage(AttributeTargets.Class)]
    public class AdvangeLoggingAttribute: Microsoft.AspNetCore.Mvc.Filters.ActionFilterAttribute
    {
        private  ILogger<AdvangeLoggingAttribute> logger;

      
        

        public override async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            if (!context.ActionDescriptor.FilterDescriptors.Any(i => i.Filter.GetType() == typeof(AdvangeLoggingAttribute)))
            {
                await next();
                return;

            }

            var logger=context.HttpContext.RequestServices.GetService<ILogger<AdvangeLoggingAttribute>> ();

            logger.LogInformation("Before action execution"+context.HttpContext.Request.Path);



            await next();


            logger.LogInformation("After action execution with statuscode"+ context.HttpContext.Response.StatusCode);

        }
    }
}
