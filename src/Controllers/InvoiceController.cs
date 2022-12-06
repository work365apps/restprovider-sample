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
    public class InvoiceController : Controller
    {
        private readonly IDataHelper _dataHelper;
        public InvoiceController(IDataHelper dataHelper)
        {
            _dataHelper = dataHelper;
        }

        /// <summary>
        /// Gets List of Provider invoices
        /// </summary>
        /// <returns>List of Provider invoices <see cref="Invoice"/></returns>
        [HttpGet]
        [Route("~/invoices")]
        public async Task<ActionResult> GetInvoices()
        {
            return Ok(_dataHelper.Get<Invoice>());
        }

        /// <summary>
        /// Get Invoice details by Id
        /// </summary>
        /// <param name="invoiceId">invoice Id</param>
        /// <returns>Invoice</returns>
        [HttpGet]
        [Route("~/invoices/{id}")]
        public async Task<ActionResult> GetInvoice(string id)
        {
            return Ok(_dataHelper.Get<Invoice>(id).FirstOrDefault());
        }

        /// <summary>
        /// Gets List of unbilled usage comsumption line items
        /// </summary>
        /// <returns>List of unbilled usage comsumption line items <see cref="ConsumptionLine"/></returns>
        [HttpGet]
        [Route("~/unbilledusages")]
        public async Task<ActionResult> GetUnbilledUsage()
        {
            return Ok(_dataHelper.Get<ConsumptionLine>().Where(c => c.Invoice is null));
        }

        /// <summary>
        /// Gets List of billed usage comsumption line items
        /// </summary>
        ///  /// <param name="id">Invoice Id</param>
        /// <returns>List of billed usage comsumption line items <see cref="ConsumptionLine"/></returns>       
        [HttpGet]
        [Route("~/invoices/{id}/billedusages")]
        public async Task<ActionResult> GetbilledUsage(string id)
        {
            return Ok(_dataHelper.Get<ConsumptionLine>().Where(c => c.Invoice != null && string.Equals(c.Invoice.Id, id, StringComparison.OrdinalIgnoreCase)));
        }
        /// <summary>
        ///  Gets List of license summary of license based products
        /// </summary>
        /// <param name="id">Invoice Id</param>
        /// <returns>List of License Summary <see cref="LicenseSummary"/></returns>
        [HttpGet]
        [Route("~/invoices/{id}/licensesummary")]
        public async Task<ActionResult> GetLicenseSummary(string id)
        {
            return Ok(_dataHelper.Get<LicenseSummary>().Where(c => c.Invoice != null && string.Equals(c.Invoice.Id, id, StringComparison.OrdinalIgnoreCase)));
        }

        /// <summary>
        /// Gets List of non recurring item summary of nonrecurring products
        /// </summary>
        /// <param name="id">Invoice Id</param>
        /// <returns>List of  non recurring item summary <see cref="NonRecurringItemSummary"/></returns>
        [HttpGet]
        [Route("~/invoices/{id}/nonrecurringitemsummary")]
        public async Task<ActionResult> GetNonRecurringItemSummary(string id)
        {
            return Ok(_dataHelper.Get<NonRecurringItemSummary>().Where(c => c.Invoice != null && string.Equals(c.Invoice.Id, id, StringComparison.OrdinalIgnoreCase)));
        }
    }
}
