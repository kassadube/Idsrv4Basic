using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Toll.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ValuesController : ControllerBase
    {
        // GET: api/Values
        [HttpGet]
        public ActionResult Get()
        {
            var claims = User.Claims.Select(x => $"{x.Type}: {x.Value}");
            return Ok(new
            {
                Name = "Values API",
                Claims = claims.ToArray()

            });
        }

       
    }
}
