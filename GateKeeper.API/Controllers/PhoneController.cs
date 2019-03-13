using GateKeeper.Models;
using GateKeeper.Twilio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Net;
using Twilio.TwiML;

namespace GateKeeper.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhoneController : ControllerBase
    {
        private readonly IOptions<AppSettings> _config;
        private readonly ITwilioService _service;

        public PhoneController(IOptions<AppSettings> config, ITwilioService service)
        {
            _config = config;
            _service = service;
        }

        [Route("Gate")]
        public IActionResult Gate(string from)
        {
            var response = _service.CreateGateResponse();

            return new ContentResult
            {
                ContentType = "text/html",
                StatusCode = 200,
                Content = response
            }; 
        }
    }
       
}