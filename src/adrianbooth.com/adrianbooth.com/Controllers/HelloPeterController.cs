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
            return ResponseBuilder.Tell("Peter is the best baby.");
        }
    }
}
