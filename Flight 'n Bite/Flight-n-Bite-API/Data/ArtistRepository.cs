using Flight_n_Bite_API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flight_n_Bite_API.Data
{
    public class ArtistRepository : IArtistRepository
    {
        private readonly FlightDbContext _context;

        public ArtistRepository(FlightDbContext context)
        {
            _context = context;
        }

        public void Add(Artist artist)
        {
            _context.Artists.Add(artist);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
