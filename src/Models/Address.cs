// Copyright (c) IOTAP, Inc. All rights reserved.

namespace Work365.Providers.RestProviders.Api.Models
{
    public class Address : Model
    {
        /// <summary>
        ///  Gets or sets the Country in ISO country code format.
        /// </summary> 
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        public string City { get; set; }

        /// <summary>
        ///  Gets or sets the state.
        /// </summary>
        public string RegionOrState { get; set; }

        /// <summary>
        /// Gets or sets the first address line.
        /// </summary>
        public string AddressLine1 { get; set; }

        /// <summary>
        ///  Gets or sets the second address line.
        /// </summary>
        public string AddressLine2 { get; set; }

        /// <summary>
        ///  Gets or sets the postal code.
        /// </summary>
        public string PostalOrZipCode { get; set; }
    }
}
