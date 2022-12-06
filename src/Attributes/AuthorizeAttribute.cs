// Copyright (c) IOTAP, Inc. All rights reserved.

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;
using Work365.Providers.RestProviders.Api.Helpers;

namespace Work365.Providers.RestProviders.Api.Attributes
{
    [AttributeUsage(validOn: AttributeTargets.Class)]
    public class AuthorizeAttribute : Attribute, IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var authorizationHelper = context.HttpContext.RequestServices.GetRequiredService<IAuthorizationHelper>();
            var (HttpStatus, Message) = authorizationHelper.IsAuthorized(context.HttpContext.Request);
            if (HttpStatus != System.Net.HttpStatusCode.OK)
            {
                context.Result = new ContentResult()
                {
                    StatusCode = (int)HttpStatus,
                    Content = Message
                };
            }

            await next();
        }
    }
}
