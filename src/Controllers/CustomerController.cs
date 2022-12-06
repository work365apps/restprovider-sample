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
    public class CustomerController : ControllerBase
    {
        private readonly IDataHelper _dataHelper;
        public CustomerController(IDataHelper dataHelper)
        {
            _dataHelper = dataHelper;
        }

        /// <summary>
        /// Creates customer in Provider
        /// </summary>
        /// <param name="customer">customer details</param>
        /// <returns>reference of created customer </returns>
        [HttpPost]
        [Route("~/customers")]
        public async Task<ActionResult> CreateCustomer(Customer customer)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(customer.Name))
                {
                    customer.Id = System.Guid.NewGuid().ToString();
                    _dataHelper.Save<Customer>(customer);
                    customer.UserCredentials = new UserCredentials()
                    {
                        UserName = "newUser@123",
                        Password = "$1234#2022"
                    };

                    return Ok(customer);
                }
                else
                {
                    return BadRequest("Please provide complete customer information");
                }
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }
        /// <summary>
        /// Returns the Customer <see cref="Customer"/> by Id
        /// </summary>
        /// <param name="Id">Customer Id</param>
        /// <returns>Customer</returns>
        [HttpGet]
        [Route("~/customers/{id}")]
        public async Task<ActionResult> GetCustomer(string id)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(id))
                {
                    return Ok(_dataHelper.Get<Customer>(id).FirstOrDefault());
                }
                else
                {
                    return BadRequest("Please provide customer id");
                }
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }
        /// <summary>
        /// Returns the List of customers available in  provider
        /// </summary>
        /// <returns>List of customers</returns>
        [HttpGet]
        [Route("~/customers")]
        public async Task<ActionResult> GetCustomers()
        {
            try
            {
                return Ok(_dataHelper.Get<Customer>());
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }
    }
}
