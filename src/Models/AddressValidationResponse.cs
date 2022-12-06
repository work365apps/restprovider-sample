// Copyright (c) IOTAP, Inc. All rights reserved.

using System.Collections.Generic;

namespace Work365.Providers.RestProviders.Api.Models
{
    public class AddressValidationResponse
    {
        /// <summary>
        /// Gets or sets the original address that needs to be validated.
        /// </summary> 
        public Address OriginalAddress { get; set; }

        /// <summary>
        ///  Gets or sets the suggested addresses if original address is incorrect or incomplete.
        /// </summary> 
        public List<Address> SuggestedAddresses { get; set; }

        /// <summary>
        /// Gets or sets the validation message incase original address is incorrect or incomplete.
        /// </summary> 
        public string ValidationMessage { get; set; }

        /// <summary>
        /// Gets or sets AddressValidationStatus enum based on validation status
        /// </summary>
        public AddressValidationStatus AddressValidationStatus { get; set; }
    }
    /// <summary>
    /// Enum for Address Validation Result
    /// </summary>
    public enum AddressValidationStatus
    {
        Success = 0,// Success Status
        Error = 1,// Error validating
        CouldNotValidate = 2// Failed Status
    }

}
