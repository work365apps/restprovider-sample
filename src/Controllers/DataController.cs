// Copyright (c) IOTAP, Inc. All rights reserved.

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Work365.Providers.RestProviders.Api.Helpers;

namespace Work365.Providers.RestProviders.Api.Controllers
{
    public class DataController : Controller
    {
        private readonly IDataHelper _dataHelper;
        private readonly IAuthorizationHelper _authorizationHelper;
        public DataController(IDataHelper dataHelper, IAuthorizationHelper authorizationHelper)
        {
            _dataHelper = dataHelper;
            _authorizationHelper = authorizationHelper;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetFileContents(string name)
        {
            var (HttpStatus, Message) = _authorizationHelper.IsAuthorized(Request);
            if (HttpStatus != System.Net.HttpStatusCode.OK)
            {
                return BadRequest(Message);
            }

            return Json(_dataHelper.GetRawContents(name));
        }

        [HttpPost]
        public async Task<IActionResult> Save(string name)
        {
            var (HttpStatus, Message) = _authorizationHelper.IsAuthorized(Request);
            if (HttpStatus != System.Net.HttpStatusCode.OK)
            {
                return BadRequest(Message);
            }

            Request.EnableBuffering();
            Request.Body.Position = 0;
            var contents = await new System.IO.StreamReader(Request.Body).ReadToEndAsync();
            _dataHelper.SaveRaw(name, contents);
            return NoContent();
        }
    }
}
