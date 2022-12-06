// Copyright (c) IOTAP, Inc. All rights reserved.

using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;
using Work365.Providers.RestProviders.Api.Attributes;
using Work365.Providers.RestProviders.Api.Helpers;
using Work365.Providers.RestProviders.Api.Models;

namespace Work365.Providers.RestProviders.Api.Controllers
{
    [Authorize]
    [Route("[controller]")]
    [ApiController]
    public class PriceListController : Controller
    {
        private readonly IDataHelper _dataHelper;
        public PriceListController(IDataHelper dataHelper)
        {
            _dataHelper = dataHelper;
        }

        /// <summary>
        /// Gets price list for a given market, product type and timeline
        /// </summary>
        /// <param name="market">market</param>
        /// <param name="type">product type</param>
        /// <param name="timeline">timeline</param>
        /// <returns>returns price list <see cref="PriceList"/> for a given market, product type and timeline</returns>
        [HttpGet]
        [Route("~/pricelists/{market}/{type}/{timeline}")]
        public async Task<ActionResult> GetPriceLists(string market, string type, string timeline)
        {
            var data = _dataHelper.Get<PriceList>().Where(p => string.Equals(p.Market, market, StringComparison.OrdinalIgnoreCase)
            && string.Equals(p.Type, type, StringComparison.OrdinalIgnoreCase)
            );
            return Ok(data);
        }
    }
}
