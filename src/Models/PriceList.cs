// Copyright (c) IOTAP, Inc. All rights reserved.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Work365.Providers.RestProviders.Api.Models
{
    public class PriceList : Model
    {
        /// <summary>
        /// Gets or sets product type (legacy,licensebased,software,azure_reservations,marketplace)
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        ///  Gets or sets product name
        /// </summary>
        public string ProductTitle { get; set; }

        /// <summary>
        ///  Gets or sets product Id
        /// </summary>
        public string ProductId { get; set; }

        /// <summary>
        ///  Gets or sets product sku Id
        /// </summary>
        public string SkuId { get; set; }

        /// <summary>
        ///  Gets or sets product sku name
        /// </summary>
        public string SkuTitle { get; set; }

        /// <summary>
        ///  Gets or sets product publisher
        /// </summary>
        public string Publisher { get; set; }

        /// <summary>
        ///  Gets or sets sku description
        /// </summary>
        public string SkuDescription { get; set; }

        /// <summary>
        ///  Gets or sets product unit of measure
        /// </summary>
        public string UnitOfMeasure { get; set; }

        /// <summary>
        ///  Gets or sets product term
        /// </summary>
        public string TermDuration { get; set; }

        /// <summary>
        ///  Gets or sets product market
        /// </summary>
        public string Market { get; set; }

        /// <summary>
        ///  Gets or sets product currency
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        ///  Gets or sets product unit price
        /// </summary>
        public decimal UnitPrice { get; set; }

        /// <summary>
        ///  Gets or sets product pricing range min
        /// </summary>
        public string PricingTierRangeMin { get; set; }

        /// <summary>
        ///  Gets or sets product pricing range max
        /// </summary>
        public string PricingTierRangeMax { get; set; }

        /// <summary>
        ///  Gets or sets product price effective start date
        /// </summary>
        public DateTime EffectiveStartDate { get; set; }

        /// <summary>
        ///  Gets or sets product price effective end date
        /// </summary>
        public DateTime EffectiveEndDate { get; set; }

        /// <summary>
        ///  Gets or sets tags 
        /// </summary>
        public string Tags { get; set; }

        /// <summary>
        ///  Gets or sets meter Ids 
        /// </summary>
        public string MeterIds { get; set; }

        /// <summary>
        ///  Gets or sets meter type 
        /// </summary>
        public string MeterType { get; set; }

        /// <summary>
        ///  Gets or sets billing plan
        /// </summary>
        public string BillingPlan { get; set; }

        /// <summary>
        ///  Gets or sets product ERP price
        /// </summary>
        public decimal ERPPrice { get; set; }

        /// <summary>
        ///  Gets or sets segment
        /// </summary>
        public string Segment { get; set; }

    }
}
