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
    public class SubscriptionController : ControllerBase
    {
        private readonly IDataHelper _dataHelper;
        public SubscriptionController(IDataHelper dataHelper)
        {
            _dataHelper = dataHelper;
        }

        /// <summary>
        /// Cancel or delete the subscription in Provider before completing the billing cycle
        /// </summary>
        /// <param name="id">subscription Id</param>
        /// <returns>true if subscription deleted</returns>
        [HttpDelete]
        [Route("~/subscriptions/{id:maxlength(50)}/cancel")]
        public async Task<ActionResult> Delete(string id)
        {
            try
            {
                var sub = _dataHelper.Get<Subscription>(id).FirstOrDefault();
                if (sub != null)
                {
                    sub.Status = SubscriptionStatus.Cancelled;
                    _dataHelper.Save<Subscription>(sub);
                    return Ok(true);
                }
                else
                {
                    return BadRequest($"Subscription Id {id} not found");
                }
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        /// <summary>
        /// Activates the subscription
        /// </summary>
        /// <param name="id">subscription Id</param>
        /// <returns>subscription</returns>
        [HttpPatch]
        [Route("~/subscriptions/{id:maxlength(50)}/activate")]
        public async Task<ActionResult> Activate(string id)
        {
            try
            {
                var sub = _dataHelper.Get<Subscription>(id).FirstOrDefault();
                if (sub != null)
                {
                    sub.Status = SubscriptionStatus.Active;
                    _dataHelper.Save<Subscription>(sub);
                    return Ok(sub);
                }
                else
                {
                    return BadRequest($"Subscription Id {id} not found");
                }
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        /// <summary>
        /// Suspends the subscription in between the billing cycle
        /// </summary>
        /// <param name="id">subscription Id</param>
        /// <returns>subscription</returns>
        [HttpPatch]
        [Route("~/subscriptions/{id:maxlength(50)}/suspend")]
        public async Task<ActionResult> Suspend(string id)
        {
            try
            {
                var sub = _dataHelper.Get<Subscription>(id).FirstOrDefault();
                if (sub != null)
                {
                    sub.Status = SubscriptionStatus.Suspended;
                    _dataHelper.Save<Subscription>(sub);
                    return Ok(sub);
                }
                else
                {
                    return BadRequest($"Subscription Id {id} not found");
                }
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        /// <summary>
        /// Expire the subscription which should not get autorenewd
        /// </summary>
        /// <param name="id">subscription Id</param>
        /// <returns>subscription</returns>
        [HttpPatch]
        [Route("~/subscriptions/{id:maxlength(50)}/expire")]
        public async Task<ActionResult> Expire(string id)
        {
            try
            { 
                var sub = _dataHelper.Get<Subscription>(id).FirstOrDefault();
                if (sub != null)
                {
                    sub.Status = SubscriptionStatus.Expired;
                    _dataHelper.Save<Subscription>(sub);
                    return Ok(sub);
                }
                else
                {
                    return BadRequest($"Subscription Id {id} not found");
                }
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }


        /// <summary>
        /// Gets list of subscription for a customer
        /// </summary>
        /// <param name="customerId">customer Id</param>
        /// <returns>List of subscriptions</returns>
        [HttpGet]
        [Route("~/customers/{id:maxlength(50)}/subscriptions")]
        public async Task<ActionResult> GetSubscriptionsByCustomerId(string id)
        {
            try
            {
                var subs = _dataHelper.Get<Subscription>().Where(s => s.Customer?.Id == id);
                return Ok(subs);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        /// <summary>
        ///  Get Subscription by subscription and customer id
        /// </summary>
        /// <param name="customerId">Customer Id</param>
        /// <param name="subscriptionId">Subscription Id</param>
        /// <returns>Subscription Object</returns>
        [HttpGet]
        [Route("~/customers/{customerId:maxlength(50)}/subscriptions/{id:maxlength(50)}")]
        public async Task<ActionResult> GetSubscription(string customerId, string id)
        {
            try
            {
                var sub = _dataHelper.Get<Subscription>(id)
                    .Where(s => s.Customer?.Id == customerId)
                    .FirstOrDefault();
                return Ok(sub);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        /// <summary>
        /// Creates new subscription in provider for a customer
        /// </summary>
        /// <param name="entity">subscription object</param>
        /// <returns>newly created subscription</returns>
        [HttpPost]
        [Route("~/subscriptions")]
        public async Task<ActionResult> CreateSubscription([FromBody] Subscription entity)
        {
            try
            {
                entity.Id = Guid.NewGuid().ToString();
                _dataHelper.Save<Subscription>(entity);
                return Ok(entity);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        /// <summary>
        /// Modifies the subscription quantity, autorenew properties
        /// </summary>
        /// <param name="id">subscription id</param>
        /// <param name="subscriptionPatchDoc">subscription object</param>
        /// <returns>modified subscription</returns>
        [HttpPatch]
        [Route("~/subscriptions")]
        public async Task<ActionResult> UpdateSubscription([FromBody] Subscription subscription)
        {
            if (subscription == null)
            {
                return BadRequest("Subscription body cannot be null!");
            } 
            try
            {
                var existingSubscription = _dataHelper.Get<Subscription>(subscription.Id).FirstOrDefault();
                if (existingSubscription == null)
                {
                    return NotFound(subscription);
                }
                _dataHelper.Save<Subscription>(subscription);
                return Ok(existingSubscription);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }
    }
}
