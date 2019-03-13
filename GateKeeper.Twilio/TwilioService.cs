using GateKeeper.Models;
using Microsoft.Extensions.Options;
using System;
using Twilio.TwiML;

namespace GateKeeper.Twilio
{
    public class TwilioService
    {
        private readonly VoiceResponse _response;
        private readonly IOptions<AppSettings> _config;

        public TwilioService(VoiceResponse response, IOptions<AppSettings> config)
        {
            _response = response;
            _config = config;
        }

        public string CreateGateResponse()
        {
            for (var i = 0; i < _config.Value.IterationCount; i++)
            {
                _response.Play(new Uri(_config.Value.DtmfToneUrl));
                _response.Pause(_config.Value.PauseLength);
            }

            return _response.ToString();
        }
    }
}
