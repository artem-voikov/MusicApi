using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ThingController : ControllerBase
    {
        [HttpGet]
        [Route("test")]
        public async Task<IActionResult> Test()
        {
            return Ok("test");
        }
    }
}
