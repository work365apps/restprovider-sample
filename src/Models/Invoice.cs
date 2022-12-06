// Copyright (c) IOTAP, Inc. All rights reserved.

using System;

namespace Work365.Providers.RestProviders.Api.Models
{
    public class Invoice : Model
    {
        /// <summary>
        /// Gets or sets date of invoice
        /// </summary>
        public DateTime InvoiceDate { get; set; }

        /// <summary>
        ///  Gets or sets amount paid out of total charges
        /// </summary>
        public decimal PaidAmount { get; set; }

        /// <summary>
        /// Gets or sets total charges
        /// </summary>
        public decimal TotalCharges { get; set; }

        /// <summary>
        /// Gets or sets Invoice Currency  Iso Code
        /// </summary>
        public string Currency { get; set; }
    }
}