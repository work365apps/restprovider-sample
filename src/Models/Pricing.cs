// Copyright (c) IOTAP, Inc. All rights reserved.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Work365.Providers.RestProviders.Api.Models
{
    /// <summary>
    /// Represents a pricing structure, which can be applied to billable items.
    /// </summary>
    public class Pricing
    {
        /// <summary>
        /// The ISO code for the currency in which this pricing is specified.
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        /// Price that the provider will charge the partner. This may not be the end customer price.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// The recommended retail price or Manufacturer's Suggested Retail Price (MSRP). This price is usually applicable to the end customer (before discounts).
        /// </summary>
        public decimal? RetailPrice { get; set; }
    }
}
