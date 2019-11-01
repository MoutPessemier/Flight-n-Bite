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

        public FlightDbContext(DbContextOptions<FlightDbContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionstring = @"Server=(localdb)\MSSQLLocalDB;Database=Flight-n-biteDB;Trusted_Connection=True;MultipleActiveResultSets=true";
            optionsBuilder.UseSqlServer(connectionstring);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Flight>().HasData(
                new Flight() { Id = 1, Number = "X44795", Departure = "Brussel", Arrival = "Madrid" }
                );
        }   


    }


}
