using Flight_n_Bite_API.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Flight_n_Bite_API.Data.Mappers
{
    public class MovieGenreConfiguration : IEntityTypeConfiguration<MovieGenre>
    {
        public void Configure(EntityTypeBuilder<MovieGenre> builder)
        {
            builder.ToTable("Movie Genre");

            builder.HasKey(m => new { m.GenreId, m.MovieId });
        }
    }
}
