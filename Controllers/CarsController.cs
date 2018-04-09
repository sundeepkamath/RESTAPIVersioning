using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RESTAPIVersioning.Controllers
{
    //Versioning by HTTP headers
    [ApiVersion("1.0")]
    [Route("api/cars")]
    public class CarssV1Controller : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "v1-bmw", "v1-mercedes" };
        }
    }

    [ApiVersion("2.0")]
    [Route("api/cars")]
    public class CarsV2Controller : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "v2-bmw", "v2-mercedes" };
        }
    }
}
