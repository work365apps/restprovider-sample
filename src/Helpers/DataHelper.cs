// Copyright (c) IOTAP, Inc. All rights reserved.

using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace Work365.Providers.RestProviders.Api.Helpers
{
    internal class DataHelper : IDataHelper
    {
        private readonly IWebHostEnvironment _environment;

        public DataHelper(IWebHostEnvironment environment)
        {
            _environment = environment;
        }

        private string GetFileNameFromType<T>() where T : Models.Model =>
            GetFileNameFromType(typeof(T).Name);

        private string GetFileNameFromType(string type)
        {
            string fileName;
            switch (type)
            {
                case "Customer": fileName = "customers.json"; break;
                case "Agreement": fileName = "agreements.json"; break;
                case "Invoice": fileName = "invoices.json"; break;
                case "ConsumptionLine": fileName = "consumptionlines.json"; break;
                case "NonRecurringItem": fileName = "nonrecurringitems.json"; break;
                case "Subscription": fileName = "subscriptions.json"; break;
                case "NonRecurringItemSummary": fileName = "nonrecurringitemsummary.json"; break;
                case "LicenseSummary": fileName = "licensesummary.json"; break;
                case "PriceList": fileName = "pricelist.json"; break;
                default: throw new ArgumentException($"'{type}' is not a supported model.");
            }

            return Path.Combine(_environment.ContentRootPath, $"App_Data\\data-files\\{fileName}");
        }

        public IEnumerable<T> Get<T>() where T : Models.Model =>
            JsonSerializer.Deserialize<IEnumerable<T>>(GetRaw<T>());

        public IEnumerable<T> Get<T>(string id) where T : Models.Model
            => Get<T>().Where(t => t.Id == id);

        public string GetRaw<T>() where T : Models.Model =>
            GetRaw(GetFileNameFromType<T>());

        public string GetRaw(string name) =>
            File.ReadAllText(name);

        public string GetRawContents(string name) =>
            File.ReadAllText(GetFileNameFromType(name));

        public void Save<T>(T t) where T : Models.Model
        {
            var collection = Get<T>().ToList();
            var existingT = collection.SingleOrDefault(x => x.Id == t.Id);
            collection.Remove(existingT);
            collection.Add(t);
            var contents = JsonSerializer.Serialize(collection);
            File.WriteAllText(GetFileNameFromType<T>(), contents);
        }

        public void SaveRaw(string name, string contents) =>
            File.WriteAllText(GetFileNameFromType(name), contents);
    }
}
