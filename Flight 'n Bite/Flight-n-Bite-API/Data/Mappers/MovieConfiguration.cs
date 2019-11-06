using Flight_n_Bite_API.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Flight_n_Bite_API.Data.Mappers
{
    public class MovieConfiguration : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.ToTable("Movie");

            builder.HasKey(m => m.Id);

            builder.Property(m => m.Director)
                .IsRequired(true);

            builder.Property(m => m.Description)
                .IsRequired(true);

            builder.Property(m => m.PosterUri)
                .IsRequired(true);

            builder.Property(m => m.Rating)
                .IsRequired(true);

            builder.Property(m => m.Title)
                .IsRequired(true);
        }
    }
}
