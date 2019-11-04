using Flight_n_Bite_API.Data.Mappers;
using Flight_n_Bite_API.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flight_n_Bite_API.Data
{

    public class FlightDbContext : DbContext
    {

        public DbSet<Flight> Flights { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Music> Songs { get; set; }
        public DbSet<Artist> Artists { get; set; }

        public FlightDbContext(DbContextOptions<FlightDbContext> options) : base(options){}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionstring = @"Server=(localdb)\MSSQLLocalDB;Database=FlightDB;Trusted_Connection=True;MultipleActiveResultSets=true";
            optionsBuilder.UseSqlServer(connectionstring);
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new MovieConfiguration());
            builder.ApplyConfiguration(new MusicConfiguration());
            builder.ApplyConfiguration(new MusicGenreConfiguration());
            builder.ApplyConfiguration(new MovieGenreConfiguration());
            builder.ApplyConfiguration(new ArtistMovieConfiguration());
            builder.ApplyConfiguration(new ArtistMusicConfiguration());
        }
    }
}
