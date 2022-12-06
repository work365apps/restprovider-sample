// Copyright (c) IOTAP, Inc. All rights reserved.

using System;

namespace Work365.Providers.RestProviders.Api.Models
{
    public class Subscription : Model
    {
        /// <summary>
        /// Gets or sets the unique product part number which is attached to subscription.
        /// </summary>
        public string PartNumber { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the subscription autorenew is enabled.
        /// </summary>
        public bool AutoRenew { get; set; }

        /// <summary>
        ///  Gets or sets the provisioning frequency <see cref="BillingCycleType"/>.
        /// </summary>
        public BillingCycleType ProvisioningFrequency { get; set; }

        /// <summary>
        /// Gets or sets the billing type <see cref="BillingTypes"/>.
        /// </summary>
        public BillingTypes BillingType { get; set; }

        /// <summary>
        ///  Gets or sets the customer Id attachted to subscription.
        /// </summary>
        public ModelRef Customer { get; set; }

        /// <summary>
        ///  Gets or sets the subscription friendly name.
        /// </summary>
        public string FriendlyName { get; set; }

        /// <summary>
        ///  Gets or sets the subscription start date.
        /// </summary>
        public DateTime StartDate { get; set; }


        /// <summary>
        /// Gets or sets status of subcription<see cref="SubscriptionStatus"/>.
        /// </summary>
        public SubscriptionStatus Status { get; set; }

        /// <summary>
        /// Gets or sets quantity.
        /// </summary>
        public decimal Quantity { get; set; }

        /// <summary>
        /// Gets or sets Cost, Selling price and currency of subscription <see cref="Pricing"/>
        /// </summary>
        public Pricing Pricing { get; set; }
    }
}