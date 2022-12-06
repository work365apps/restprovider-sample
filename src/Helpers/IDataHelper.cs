// Copyright (c) IOTAP, Inc. All rights reserved.

using System.Collections.Generic;

namespace Work365.Providers.RestProviders.Api.Helpers
{
    public interface IDataHelper
    {
        IEnumerable<T> Get<T>() where T : Models.Model;
        IEnumerable<T> Get<T>(string id) where T : Models.Model;
        void Save<T>(T t) where T : Models.Model;

        string GetRaw(string name);
        string GetRawContents(string name);
        void SaveRaw(string name, string contents);
    }
}
