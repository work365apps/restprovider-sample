// Copyright (c) IOTAP, Inc. All rights reserved.

namespace Work365.Providers.RestProviders.Api.Models
{
    public class ProviderProperty
    {
        /// <summary>
        /// Gets or sets whether provider supports agreement confirmation for customer creation
        /// </summary>
        public bool SupportsAgreementConfirmation { get; set; }

        /// <summary>
        /// Gets or sets whether provider supports address vrification for customer creation
        /// </summary>
        public bool SupportsAddressVerification { get; set; }

        /// <summary>
        ///  Gets or sets whether provider supports new customer creation
        /// </summary>
        public bool SupportsCustomerCreation { get; set; }
    }
}
