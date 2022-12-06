// Copyright (c) IOTAP, Inc. All rights reserved.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Work365.Providers.RestProviders.Api.Models
{
    public class NonRecurringItemSummary : Model
    {/// <summary>
     ///  Gets or sets product part number
     /// </summary>
        public string PartNumber { get; set; }

        /// <summary>
        /// Gets or sets nonrecurringitem reference
        /// </summary>
        public ModelRef NonRecurringItem { get; set; }

        /// <summary>
        /// Gets or sets customer reference
        /// </summary>
        public ModelRef Customer { get; set; }

        /// <summary>
        /// Gets or sets subscription reference
        /// </summary>
        public ModelRef Subscription { get; set; }

        /// <summary>
        /// Gets or sets invoice reference
        /// </summary>
        public ModelRef Invoice { get; set; }

        /// <summary>
        ///  Gets or sets billing cycle type
        /// </summary>
        public BillingCycleType BillingCycleType { get; set; }

        /// <summary>
        ///  Gets or sets order id
        /// </summary>
        public string OrderId { get; set; }

        /// <summary>
        /// Gets or sets charge start date
        /// </summary>
        public DateTime ChargeStartDate { get; set; }

        /// <summary>
        /// Gets or sets charge end date
        /// </summary> 
        public DateTime ChargeEndDate { get; set; }

        /// <summary>
        /// Gets or sets charge description
        /// </summary>
        public string ChargeDescription { get; set; }

        /// <summary>
        /// Gets or sets unit price
        /// </summary>
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// Gets or sets quantity
        /// </summary>
        public decimal Quantity { get; set; }

        /// <summary>
        /// Gets or sets tax
        /// </summary>
        public decimal Tax { get; set; }

        /// <summary>
        ///  Gets or sets discount
        /// </summary>
        public decimal Discount { get; set; }

        /// <summary>
        /// Gets or sets total
        /// </summary>
        public decimal Total { get; set; }

        /// <summary>
        ///  Gets or sets currency ISO code
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        ///  Gets or sets manufacturer
        /// </summary>
        public string Manufacturer { get; set; }
    }
}
