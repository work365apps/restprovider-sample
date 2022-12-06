// Copyright (c) IOTAP, Inc. All rights reserved.

namespace Work365.Providers.RestProviders.Api.Models
{
    public class ModelRef
    {
        /// <summary>
        /// The primary key for the model.
        /// </summary>
        public virtual string Id { get; set; }

        /// <summary>
        /// A friendly name for the model.
        /// </summary>
        public virtual string Name { get; set; }

        public static ModelRef CreateReference(string id, string name = null)
        {
            if (string.IsNullOrEmpty(id)) { return null; }
            return new ModelRef()
            {
                Id = id,
                Name = name
            };
        }
    }
}
