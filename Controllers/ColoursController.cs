using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RESTAPIVersioning.Controllers
{
    //Versioning by URL path segment
    [ApiVersion("1.0")]
    [Route("api/v{ver:apiVersion}/colours")]
    public class ColoursV1Controller : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "v1-red", "v1-orange" };
        }
    }

    [ApiVersion("2.0")]
    [ApiVersion("3.0")]
    [Route("api/v{ver:apiVersion}/colours")]
    public class ColoursV2Controller : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "v2-red", "v2-orange" };
        }

        [HttpGet, MapToApiVersion("3.0")]
        public IEnumerable<string> GetV3()
        {
            return new string[] { "v3-red", "v3-orange" };
        }
    }
}
