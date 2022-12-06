// Copyright (c) IOTAP, Inc. All rights reserved.

using System;

namespace Work365.Providers.RestProviders.Api.Models
{
    public class NonRecurringItem : Model
    {
        /// <summary>
        /// Gets or sets the unique product part number which is attached to subscription.
        /// </summary>
        public string PartNumber { get; set; }

        /// <summary>
        /// Gets or sets friendly name of item
        /// </summary>
        public string FriendlyName { get; set; }

        /// <summary>
        /// Gets or sets description of item
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets Customer reference
        /// </summary>
        public ModelRef Customer { get; set; }

        /// <summary>
        /// Gets or sets Quantity
        /// </summary>
        public decimal Quantity { get; set; }

        /// <summary>
        /// Gets or sets Cost, Selling price and currency of NRI Item <see cref="Pricing"/>
        /// </summary>
        public Pricing Pricing { get; set; }

        /// <summary>
        /// Gets or sets Effective start Date  of item
        /// </summary>
        public DateTime EffectiveDate { get; set; }

        /// <summary>
        /// Gets or sets Expiry Date of item
        /// </summary>
        public DateTime ExpiryDate { get; set; }
    }
}
