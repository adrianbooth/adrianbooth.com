using System;
using System.Diagnostics;
using Alexa.NET;
using Alexa.NET.Request;
using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace adrianbooth.com.Controllers
{
    [Route("api/[controller]")]
    public class HelloPeterController : Controller
    {

        [HttpPost]
        public dynamic Post(SkillRequest request)
        {
            var index = DateTime.UtcNow.Ticks % 7;
            Log.Debug("request received {request}", request);

            string[] responses = {
                "Peter is the best baby",
                "Peter is the best baby",
                "Peter is the best baby",
                "Love you Peter",
                "do ya like dags",
                "Jakes farts melt steel beams",
                "He's a bad baby"
            };
            return ResponseBuilder.Tell(responses[index]);
        }
    }
}
