using System;
using Microsoft.AspNetCore.Mvc;

namespace aspnet_core
{
    [Route("v1")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet("square/{value}")]
        public IActionResult Square(double value)
        {
            var result = Math.Pow(value, 2);
            return Ok(new {
                value = value,
                result = result
            });
        }
    }
}
