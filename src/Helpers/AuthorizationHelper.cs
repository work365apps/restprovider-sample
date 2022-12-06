// Copyright (c) IOTAP, Inc. All rights reserved.

using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System.Net;

namespace Work365.Providers.RestProviders.Api.Helpers
{
    public class AuthorizationHelper : IAuthorizationHelper
    {
        private readonly IConfiguration _configuration;
        public AuthorizationHelper(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string ApiHeaderKey => "work-365-rest-provider-api-key";

        public (HttpStatusCode HttpStatus, string Message) IsAuthorized(HttpRequest request)
        {
            if (request?.Headers?.ContainsKey(ApiHeaderKey) != true)
            {
                return (HttpStatusCode.Forbidden, "Unknown client!");
            }

            var key = _configuration.GetValue<string>(ApiHeaderKey);

            // Case sensitive match!
            if (string.Equals(request.Headers[ApiHeaderKey], key, System.StringComparison.Ordinal))
            {
                return (HttpStatusCode.OK, "Ok");
            }
            else
            {
                return (HttpStatusCode.Forbidden, "Invalid client!");
            }
        }
    }
}
