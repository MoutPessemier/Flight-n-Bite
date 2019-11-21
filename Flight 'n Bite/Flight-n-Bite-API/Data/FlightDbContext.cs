using Flight_n_Bite_API.Data.Mappers;
using Flight_n_Bite_API.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Flight_n_Bite_API.Data
{

    public class FlightDbContext : IdentityDbContext
    {

        public DbSet<Flight> Flights { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Music> Songs { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }
        public DbSet<Personnel> Personnels { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Group> Groups { get; set; }

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
            builder.ApplyConfiguration(new ProductConfiguration());
            builder.ApplyConfiguration(new OrderConfiguration());
            builder.ApplyConfiguration(new OrderLineConfiguration());
            builder.ApplyConfiguration(new PassengerConfiguration());
            builder.ApplyConfiguration(new PersonnelConfiguration());
            builder.ApplyConfiguration(new MessageConfiguration());
        }
    }
}
