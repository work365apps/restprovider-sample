// Copyright (c) IOTAP, Inc. All rights reserved.

using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Work365.Providers.RestProviders.Api.Attributes;
using Work365.Providers.RestProviders.Api.Helpers;
using Work365.Providers.RestProviders.Api.Models;

namespace Work365.Providers.RestProviders.Api.Controllers
{
    [Authorize]
    [Route("[controller]")]
    [ApiController]
    public class NonRecurringItemController : Controller
    {

        private readonly IDataHelper _dataHelper;
        public NonRecurringItemController(IDataHelper dataHelper)
        {
            _dataHelper = dataHelper;
        }
        /// <summary>
        /// Gets list of all <see cref="NonRecurringItem"/>
        /// </summary>
        /// <returns>list of all <see cref="NonRecurringItem"/></returns>
        [HttpGet]
        [Route("~/nonrecurringitems")]
        public async Task<ActionResult> GetNonRecurringItems()
        {
            return Ok(_dataHelper.Get<NonRecurringItem>());
        }

        /// <summary>
        /// Gets List of NonRecurringItems from tenant and sync it back to Provider
        /// </summary>
        /// <param name="nonRecurringItems"> List of NonRecurringItems from tenant</param>        
        [HttpPost]
        [Route("~/nonrecurringitems")]
        public async Task<ActionResult> Post([FromBody] List<NonRecurringItem> nonRecurringItems)
        {
            nonRecurringItems.ForEach(n => _dataHelper.Save(n));
            return NoContent();
        }
    }
}
