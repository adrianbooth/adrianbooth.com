using System;
using System.Diagnostics;
using Alexa.NET;
using Alexa.NET.Request;
using Microsoft.AspNetCore.Mvc;

namespace adrianbooth.com.Controllers
{
    [Route("api/[controller]")]
    public class HelloPeterController : Controller
    {

        [HttpPost]
        public dynamic Post(SkillRequest input)
        {
            var index = DateTime.UtcNow.Ticks % 7;
            string[] responses = {
                "Peter is the best baby",
                "Peter is the best baby",
                "Peter is the best baby",
                "Love you Peter",
                "da ya likee dags",
                "Jakes farts melt steel beams",
                "He's a bad baby"
            };
            return ResponseBuilder.Tell(responses[index]);
        }
    }
}
