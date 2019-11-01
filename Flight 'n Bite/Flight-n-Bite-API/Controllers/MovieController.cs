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
    public class MovieController : ControllerBase
    {
        private readonly IMovieRepository _movieRepository;

        public MovieController(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        [HttpGet]
        public IEnumerable<Movie> GetMovies()
        {
            return _movieRepository.GetMovies();
        }

        [HttpGet("{id}")]
        public Movie GetMovie(int id)
        {
            return _movieRepository.GetMovie(id);
        }
    }
}