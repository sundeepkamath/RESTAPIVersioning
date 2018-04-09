using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RESTAPIVersioning.Controllers
{
    //Versioning by Query Parameters
    [ApiVersion("1.0")]
    [Route("api/values")]
    public class ValuesV1Controller : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "v1-value1", "v1-value2" };
        }
    }

    [ApiVersion("2.0")]
    [Route("api/values")]
    public class ValuesV2Controller : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "v2-value1", "v2-value2" };
        }
    }
}
