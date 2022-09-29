using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Infrastructure;

namespace VivaBarNails.Authorization
{
    public class AdminAuthorizationHandler : AuthorizationHandler<OperationAuthorizationRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, OperationAuthorizationRequirement requirement)
        {

            if (context.User.IsInRole(Constants.AdminRole))
                context.Succeed(requirement);
            return Task.CompletedTask;
        }
    }
}
