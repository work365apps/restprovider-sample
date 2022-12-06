// Copyright (c) IOTAP, Inc. All rights reserved.

using System.Collections.Generic;

namespace Work365.Providers.RestProviders.Api.Models
{
    public class ValidationRulesForCountry
    {
        /// <summary>
        /// Gets or sets default supported language by country
        /// </summary>
        public string DefaultSupportedLanguage { get; set; }
        /// <summary>
        /// Gets or sets default culture
        /// </summary>
        public string DefaultCulture { get; set; }

        /// <summary>
        /// Gets or sets whether state is required in address or not
        /// </summary>
        public bool IsStateRequired { get; set; }

        /// <summary>
        /// Gets or sets whether city is required in address or not
        /// </summary>
        public bool IsCityRequired { get; set; }

        /// <summary>
        /// Gets or sets whether postal code is required in address or not
        /// </summary>
        public bool IsPostalCodeRequired { get; set; }

        /// <summary>
        /// Gets or sets the list of supported states of a country
        /// </summary>
        public List<string> StateList { get; set; }

        /// <summary>
        /// Gets or sets phone number regular expression which can be used to validate the phone number pattern followed by country
        /// </summary>
        public string PhoneNumberRegex { get; set; }

        /// <summary>
        /// Gets or sets postal code regular expression which can be used to validate the postal code pattern followed by country
        /// </summary>
        public string PostalCodeRegex { get; set; }

        /// <summary>
        /// Gets or sets whether Tax Id is required or not
        /// </summary>
        public bool IsTaxIdSupported { get; set; }

        /// <summary>
        /// Gets or sets whether Vat Id is required or not
        /// </summary>
        public bool IsVatIdSupported { get; set; }

        /// <summary>
        /// Gets or sets Vat Id regular expression which can be used to validate the Vat Id pattern followed by country
        /// </summary>
        public string VatIdRegex { get; set; }

        /// <summary>
        /// Gets or sets Tax Id format which can be used as example how the Tax Id pattern is followed by country
        /// </summary>
        public string TaxIdFormat { get; set; }

        /// <summary>
        /// Gets or sets Tax Vat Id is optional or not
        /// </summary>
        public bool IsTaxIdOptional { get; set; }
    }
}
