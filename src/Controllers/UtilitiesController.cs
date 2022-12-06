// Copyright (c) IOTAP, Inc. All rights reserved.

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Work365.Providers.RestProviders.Api.Attributes;
using Work365.Providers.RestProviders.Api.Models;

namespace Work365.Providers.RestProviders.Api.Controllers
{
    [Authorize]
    [Route("[controller]")]
    [ApiController]
    public class UtilitiesController : ControllerBase
    {
        /// <summary>
        /// Checks for the availability of a domain.
        /// </summary>
        /// <param name="domain">The fully qualified domain name.</param>
        /// <returns>true if the the domain is available, false otherwise.</returns>
        [HttpGet]
        [Route("~/utilities/domain-check/{domain}")]
        public async Task<ActionResult> DomainAvailability(string domain)
        {
            List<string> availableDomains = new List<string>()
            {
                "iotap.com",
                "microsoft.com",
                "google.com"
            };

            return Ok(availableDomains.Any(x => string.Equals(x, domain, StringComparison.OrdinalIgnoreCase)));
        }

        /// <summary>
        /// Validates address
        /// </summary>
        /// <returns>returns <see cref=AddressValidationResponse></cref></returns>
        [HttpPost]
        [Route("~/utilities/validate-address")]
        public async Task<ActionResult> ValidateAddress(Address address)
        {
            if (address != null && address.RegionOrState == "Florida" && address.PostalOrZipCode == "111")
            {
                return Ok(new AddressValidationResponse()
                {
                    AddressValidationStatus = AddressValidationStatus.Success,
                    OriginalAddress = new Address()
                    {
                        AddressLine1 = address.AddressLine1,
                        AddressLine2 = address.AddressLine2,
                        City = address.City,
                        RegionOrState = address.RegionOrState,
                        Country = address.Country,
                        PostalOrZipCode = address.PostalOrZipCode
                    },
                    ValidationMessage = "Address validated successfully"
                });
            }
            else
            {
                return Ok(new AddressValidationResponse()
                {
                    AddressValidationStatus = AddressValidationStatus.CouldNotValidate,
                    OriginalAddress = new Address()
                    {
                        AddressLine1 = address.AddressLine1,
                        AddressLine2 = address.AddressLine2,
                        City = address.City,
                        RegionOrState = address.RegionOrState,
                        Country = address.Country,
                        PostalOrZipCode = address.PostalOrZipCode
                    },
                    SuggestedAddresses = new List<Address>() {
                    new Address()
                    {
                         AddressLine1 = "AddressLine1",
                        AddressLine2 = "AddressLine2",
                        City = "City",
                        RegionOrState = "Florida",
                        Country = "Country",
                        PostalOrZipCode = "111"
                    },
                    new Address()
                    {
                         AddressLine1 = "AddressLine1",
                        AddressLine2 = "AddressLine2",
                        City = "City",
                        RegionOrState = "Texas",
                        Country = "Country",
                        PostalOrZipCode = "112"
                    }
                    },
                    ValidationMessage = "Address could not be validated"
                });

            }
        }

        /// <summary>
        /// returns Validation Rules By Country for country
        /// </summary>
        /// <param name="countrycode">country code</param>
        /// <returns><see cref="ValidationRulesForCountry"/></returns>
        [HttpGet]
        [Route("~/countries/{countrycode}/validation-rules")]
        public async Task<ActionResult> ValidationRulesByCountry(string countrycode)
        {
            return Ok(new ValidationRulesForCountry()
            {
                DefaultSupportedLanguage = "en-US",
                DefaultCulture = "",
                IsCityRequired = false,
                IsStateRequired = true,
                StateList = new List<string>() { "Florida", "Texas", "Alaska" },
                IsPostalCodeRequired = true,
                PhoneNumberRegex = "",
                PostalCodeRegex = "",
                IsTaxIdSupported = false,
                IsVatIdSupported = true,
                VatIdRegex = "",
                TaxIdFormat = "ABC001F552",
                IsTaxIdOptional = true
            });
        }
        [HttpGet]
        [Route("~/utilities/provider-properties")]
        public async Task<ActionResult> GetProviderProperties()
        {
            return Ok(new ProviderProperty()
            {
                SupportsAddressVerification = true,
                SupportsAgreementConfirmation = true,
                SupportsCustomerCreation = true
            });
        }
    }
}
