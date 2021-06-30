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
        [Route("find-songs")]
        public async Task<IActionResult> FindSongs([FromQuery] string template)
        {
            var response = await musicService.FindSongs(template);
            var result = response.Select(x => mapper.Map<VmSong>(x));

            return Ok(result);
        }
        
        [HttpGet]
        [Route("album/{id}")]
        public async Task<IActionResult> GetAlbum(int id)
        {
            var response = await musicService.GetAlbum(id);
            var result = mapper.Map<VmAlbum>(response);

            return Ok(result);
        }
        
        [HttpGet]
        [Route("artist/{id}")]
        public async Task<IActionResult> GetArtist(int id)
        {
            var response = await musicService.GetArtist(id);
            var result = mapper.Map<VmArtist>(response);

            return Ok(result);
        }

    }
}
