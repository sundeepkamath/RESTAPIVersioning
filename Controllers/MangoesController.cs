using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RESTAPIVersioning.Controllers
{
    //Versioning by HTTP headers
    [ApiVersion("1.0")]
    [Route("api/mangoes")]
    public class MangoesV1Controller : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "v1-alphanso", "v1-kesar" };
        }
    }

    [ApiVersion("2.0")]
    [Route("api/mangoes")]
    public class MangoesV2Controller : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "v2-alphanso", "v2-kesar" };
        }
    }
}
