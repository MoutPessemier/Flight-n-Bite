using Flight_n_Bite_API.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Flight_n_Bite_API.Data.Mappers
{
    public class MusicGenreConfiguration : IEntityTypeConfiguration<MusicGenre>
    {
        public void Configure(EntityTypeBuilder<MusicGenre> builder)
        {
            builder.ToTable("MusicGenre");

            builder.HasKey(m => new { m.MusicId, m.GenreId });
        }
    }
}
