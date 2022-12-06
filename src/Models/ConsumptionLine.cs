// Copyright (c) IOTAP, Inc. All rights reserved.

using System;

namespace Work365.Providers.RestProviders.Api.Models
{
    public class ConsumptionLine : Model
    {
        /// <summary>
        /// Gets or sets billing cycle start date
        /// </summary>
        public DateTime CycleStartDate { get; set; }

        /// <summary>
        /// Gets or sets billing cycle end date
        /// </summary> 
        public DateTime CycleEndDate { get; set; }

        /// <summary>
        /// Gets or sets Subscription reference
        /// </summary>
        public ModelRef Subscription { get; set; }

        /// <summary>
        /// Gets or sets Invoice reference
        /// </summary>
        public ModelRef Invoice { get; set; }

        /// <summary>
        ///  Gets or sets billing currency Iso code
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        /// Gets or sets Customer reference
        /// </summary>
        public ModelRef Customer { get; set; }

        /// <summary>
        /// Gets or sets Service
        /// </summary>
        public string Service { get; set; }

        /// <summary>
        /// Gets or sets Resource
        /// </summary>
        public string Resource { get; set; }

        /// <summary>
        ///  Gets or sets Charge Type
        /// </summary>
        public string ChargeType { get; set; }

        /// <summary>
        /// Gets or sets billing unit
        /// </summary>
        public string Unit { get; set; }

        /// <summary>
        /// Gets or sets Region
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// Gets or sets Tax on invoice
        /// </summary>
        public decimal Tax { get; set; }

        /// <summary>
        /// Gets or sets billing total
        /// </summary>
        public decimal Total { get; set; }

        /// <summary>
        /// Gets or sets Unit Price
        /// </summary>
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// Gets or sets billing Quantity
        /// </summary>
        public decimal Quantity { get; set; }
    }
}
