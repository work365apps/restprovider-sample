// Copyright (c) IOTAP, Inc. All rights reserved.

using Microsoft.AspNetCore.Http;
using System.Net;

namespace Work365.Providers.RestProviders.Api.Helpers
{
    public interface IAuthorizationHelper
    {
        string ApiHeaderKey { get; }

        (HttpStatusCode HttpStatus, string Message) IsAuthorized(HttpRequest request);
    }
}