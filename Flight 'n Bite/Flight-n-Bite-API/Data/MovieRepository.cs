using Flight_n_Bite_API.Model;
using Microsoft.EntityFrameworkCore;
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

        public void Add(Movie movie)
        {
            _context.Movies.Add(movie);
        }

        public Movie GetMovie(int id)
        {
            return _context.Movies.Include(a => a.Cast).FirstOrDefault(m => m.Id == id);
        }

        public IEnumerable<Movie> GetMovies()
        {
            return _context.Movies.Include(a => a.Cast).ToList();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
