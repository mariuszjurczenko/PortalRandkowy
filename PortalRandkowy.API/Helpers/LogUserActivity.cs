using System;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.DependencyInjection;
using PortalRandkowy.API.Data;

namespace PortalRandkowy.API.Helpers
{
    public class LogUserActivity : IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var resultContext = await next();

            var repo = resultContext.HttpContext.RequestServices.GetService<IUserRepository>();

            var userId = int.Parse(resultContext.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value);
            var user = await repo.GetUser(userId);
            user.LastActive = DateTime.Now;

            await repo.SaveAll();
        }
    }
}