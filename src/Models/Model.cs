// Copyright (c) IOTAP, Inc. All rights reserved.

using System;

namespace Work365.Providers.RestProviders.Api.Models
{
    public class Model : ModelRef
    {
        public virtual DateTime? CreatedOn { get; set; }

        /// <summary>
        /// When the record was last modified in the source system.
        /// </summary>
        public virtual DateTime? ModifiedOn { get; set; }
    }
}
