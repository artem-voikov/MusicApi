using AutoMapper;
using Domain.Entities;
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
        private readonly IMapper mapper;

        public MusicController(IMusicService musicService, IMapper mapper)
        {
            this.musicService = musicService;
            this.mapper = mapper;
        }
        [HttpGet]
        [Route("test")]
        public async Task<IActionResult> Test([FromQuery] string template)
        {
            var response = await musicService.GetSongs(template);
            var result = response.Select(x => mapper.Map<VmSong>(x));

            return Ok(result);
        }

    }
}
