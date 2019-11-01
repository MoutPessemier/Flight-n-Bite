using Flight_n_Bite_API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flight_n_Bite_API.Data
{
    public class MovieRepository : IMovieRepository
    {
        private readonly FlightDbContext _context;

        public MovieRepository(FlightDbContext context)
        {
            _context = context;
        }

        public Movie GetMovie(int id)
        {
            return _context.Movies.FirstOrDefault(m => m.Id == id);
        }

        public IEnumerable<Movie> GetMovies()
        {
            return _context.Movies.ToList();
        }
    }
}
