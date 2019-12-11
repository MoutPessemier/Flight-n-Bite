using Flight_n_Bite_API.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Flight_n_Bite_API.Data
{
    public class MusicRepository : IMusicRepository
    {
        private readonly FlightDbContext _context;

        public MusicRepository(FlightDbContext context)
        {
            _context = context;
        }

        public void Add(Music music)
        {
            _context.Songs.Add(music);
        }

        public Music GetSong(int id)
        {
            return _context.Songs.Include(a => a.Artist).Include(a => a.CoArtists).FirstOrDefault(s => s.Id == id);
        }

        public IEnumerable<Music> GetSongs()
        {
            return _context.Songs.Include(a => a.Artist).Include(a => a.CoArtists).ToList();
        }

        public void SaveChagnes()
        {
            _context.SaveChanges();
        }
    }
}
