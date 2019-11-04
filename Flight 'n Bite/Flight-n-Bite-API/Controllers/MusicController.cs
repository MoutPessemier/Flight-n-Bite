using System.Collections.Generic;
using Flight_n_Bite_API.Model;
using Microsoft.AspNetCore.Mvc;

namespace Flight_n_Bite_API.Controllers
{
    [Route("api/[controller]")]
    [ApiConventionType(typeof(DefaultApiConventions))]
    [Produces("application/json")]
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