// Copyright (c) IOTAP, Inc. All rights reserved.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Work365.Providers.RestProviders.Api.Models
{
    public enum BillingTypes
    {
        /// <summary>
        ///  Indicates that the <see cref="Subscription"/> is license-based.
        /// </summary>
        LicenseBased = 1,

        /// <summary>
        /// Indicates that the <see cref="Subscription"/> is usage-based.
        /// </summary>
        UsageBased = 2,

        /// <summary>
        ///Indicates that the <see cref="Subscription"/> is service-based.
        /// </summary>
        ServiceBased = 3,

        /// <summary>
        ///  Indicates that the <see cref="Subscription"/> is tiered-based.
        /// </summary>
        TieredBased = 4,

        /// <summary>
        /// Indicates that the type is NonRecurringItem.
        /// </summary>
        NonRecurringItem = 5
    }
}
