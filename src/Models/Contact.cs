// Copyright (c) IOTAP, Inc. All rights reserved.

namespace Work365.Providers.RestProviders.Api.Models
{
    public class Contact : Model
    {
        /// <summary>
        /// Gets or sets First Name of contact
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets Last Name of contact
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets Phone Number of contact
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets Email of contact
        /// </summary>
        public string Email { get; set; }
    }
}
