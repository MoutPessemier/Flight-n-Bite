using System.Collections.Generic;

namespace Flight_n_Bite_API.Model
{
    public interface IMovieRepository
    {
        IEnumerable<Movie> GetMovies();
        Movie GetMovie(int id);
        void Add(Movie movie);
        void SaveChanges();
    }
}
