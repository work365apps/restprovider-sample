// Copyright (c) IOTAP, Inc. All rights reserved.

using System;

namespace Work365.Providers.RestProviders.Api.Models
{
    public class Agreement : Model
    {
        /// <summary>
        /// Gets or sets Agreeemnet Signed By
        /// </summary>
        public Contact SignedBy { get; set; }

        /// <summary>
        /// Gets or sets Customer reference
        /// </summary>
        public ModelRef Customer { get; set; }

        /// <summary>
        /// Gets or sets Agreeemnet Signed On
        /// </summary>
        public DateTime SignedOn { get; set; }

        /// <summary>
        /// Gets or sets Agreeemnet Template Id <see cref="AgreementTemplate"/>
        /// </summary>
        public string TemplateId { get; set; }
    }
}
