using System.Diagnostics;
using Alexa.NET;
using Microsoft.AspNetCore.Mvc;

namespace adrianbooth.com.Controllers
{
    [Route("api/[controller]")]
    public class HelloPeterController : Controller
    {
        [HttpPost]
        public dynamic Post(dynamic value)
        {
            Trace.WriteLine(value, "request");
            return ResponseBuilder.Tell("Peter is the best baby.");
        }
    }
}
