// Copyright (c) IOTAP, Inc. All rights reserved.

namespace Work365.Providers.RestProviders.Api.Models
{
    public class UserCredentials : Model
    {
        /// <summary>
        /// Gets or sets the username of customer
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        public string Password { get; set; }
    }
}
