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
    public class AgreementsController : ControllerBase
    {
        private readonly IDataHelper _dataHelper;
        public AgreementsController(IDataHelper dataHelper)
        {
            _dataHelper = dataHelper;
        }

        /// <summary>
        /// Submits the specified <see cref="Agreement"/> for acceptance.
        /// </summary>
        /// <param name="agreement">The agreement details.</param>
        [HttpPost]
        [Route("~/agreements")]
        public async Task<ActionResult> AcceptAgreement(Agreement agreement)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(agreement.TemplateId) && !string.IsNullOrWhiteSpace(agreement.Customer?.Id))
                {
                    agreement.Id = Guid.NewGuid().ToString();
                    _dataHelper.Save<Agreement>(agreement);
                    return Ok(agreement);
                }
                else
                {
                    return BadRequest("Please provider all details");
                }
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }
        /// <summary>
        /// Submits the specified <see cref="Agreement"/> for acceptance.
        /// </summary>
        /// <param name="agreement">The agreement details.</param>
        [HttpGet]
        [Route("~/customers/{id}/agreements")]
        public async Task<ActionResult> CustomerAgreement(string id)
        {
            var agreements = _dataHelper.Get<Agreement>();
            return Ok(agreements.Where(a => a.Customer?.Id == id));
        }
    }
}
