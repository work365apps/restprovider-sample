// Copyright (c) IOTAP, Inc. All rights reserved.

namespace Work365.Providers.RestProviders.Api.Models
{
    public class Customer : Model
    {
        /// <summary>
        /// Gets or sets email address
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets language
        /// </summary>
        public string Language { get; set; }

        /// <summary>
        /// Gets or sets culture
        /// </summary>
        public string Culture { get; set; }

        /// <summary>
        /// Gets or sets default address
        /// </summary>
        public Address DefaultAddress { get; set; }

        /// <summary>
        /// Gets or sets domain name
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// Gets or sets organization registration number
        /// </summary>
        public string OrganizationRegistrationNumber { get; set; }

        /// <summary>
        /// Gets or sets credentials <see cref="UserCredentials"/>
        /// </summary>
        public UserCredentials UserCredentials { get; set; }
        /// <summary>
        /// Gets or sets Customer contact details
        /// </summary>
        public Contact Contact { get; set; }

    }
}
