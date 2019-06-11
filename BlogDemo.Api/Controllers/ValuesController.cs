using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BlogDemo.Api.Controllers
{
    [Route("api/values")]
    [ApiController]
    public class ValuesController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("OK");
        }
    }
}