// Copyright (c) IOTAP, Inc. All rights reserved.

namespace Work365.Providers.RestProviders.Api.Models
{
    /// <summary>
    /// Lists the available states for a subscription. 
    /// </summary>
    public enum SubscriptionStatus
    {
        /// <summary>
        /// Active subscription.
        /// </summary>
        Active = 1,

        /// <summary>
        /// Indicates the subscription is suspended but can be resumed back to active state.
        /// </summary>
        Suspended = 2,

        /// <summary>
        /// Indicates the subscription is deleted before completion of billing period and cannot be resumed back
        /// </summary>
        Cancelled = 3,

        /// <summary>
        ///Indicates the subscription is expired and is not autorenewed.
        /// </summary>
        Expired = 4
    }
}
