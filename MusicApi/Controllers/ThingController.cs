using Microsoft.AspNetCore.Mvc;
using NLog;
using System;
using System.Threading.Tasks;

namespace MusicApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ThingController : ControllerBase
    {
        private readonly ILogger logger;

        public ThingController(ILogger logger )
        {
            this.logger = logger;
        }

        [HttpGet]
        [Route("test")]
        public async Task<IActionResult> Test()
        {
            throw new Exception("test exception");
            logger.Info("test");

            return Ok("test");
        }
    }
}
