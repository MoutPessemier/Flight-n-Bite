using Flight_n_Bite_API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flight_n_Bite_API.Data
{
    public class MusicRepository : IMusicRepository
    {
        private readonly FlightDbContext _context;

        public MusicRepository(FlightDbContext context)
        {
            _context = context;
        }

        public Music GetSong(int id)
        {
            return _context.Songs.FirstOrDefault(s => s.Id == id);
        }

        public IEnumerable<Music> GetSongs()
        {
            return _context.Songs.ToList();
        }
    }
}
