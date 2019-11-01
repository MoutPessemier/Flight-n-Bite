using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Flight_n_Bite_API.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Flight_n_Bite_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusicController : ControllerBase
    {
        private readonly IMusicRepository _musicRepository;

        public MusicController(IMusicRepository musicRepository)
        {
            _musicRepository = musicRepository;
        }

        [HttpGet]
        public IEnumerable<Music> GetSongs() {
           return _musicRepository.GetSongs();
        }

        [HttpGet("{id}")]
        public Music GetSong(int id)
        {
            return _musicRepository.GetSong(id);
        }
    }
}