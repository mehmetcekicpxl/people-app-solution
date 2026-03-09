using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;

namespace PeopleApp.API.UI.Attributes
{
    [AttributeUsage(validOn: AttributeTargets.Class)]
    public class ApiKeyAttribute : Attribute, IAsyncActionFilter
    {
        private const string APIKEYNAME = "ApiKey";
        private const string APIKEYVALUE = "ApoKey";
        public Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
           if(!context.HttpContext.Request.Headers.TryGetValue(APIKEYNAME, out var apiKeyValue) || apiKeyValue != APIKEYVALUE)
            {
                context.Result = new UnauthorizedResult();
                return Task.CompletedTask;
            }
            return next();
        }
    }
}
