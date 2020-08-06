using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace webapi.Controllers
{
    [Route("api")]
    [ApiController]
    public class MyApiController : ControllerBase
    {
        [Route("cc")]
        public string test(string name) {
            return "Welcome to my test api,&&    "+name;
        }
    }
}
