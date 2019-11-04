using Flight_n_Bite_API.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flight_n_Bite_API.Data.Mappers
{
    public class ArtistMovieConfiguration : IEntityTypeConfiguration<ArtistMovie>

    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<ArtistMovie> builder)
        {
            builder.ToTable("ArtistMovie");
            builder.HasKey(a => new { a.ArtistId, a.MovieId });
        }
    }
}
