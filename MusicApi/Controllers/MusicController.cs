using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MusicController : ControllerBase
    {
        private readonly IMusicService musicService;

        public MusicController(IMusicService musicService)
        {
            this.musicService = musicService;
        }
        [HttpGet]
        [Route("test")]
        public async Task<IActionResult> Test([FromQuery] string template)
        {
            var result = await musicService.GetSongs(template);
            return Ok($"test search gives: {result.Count} result");
        }

    }
}
