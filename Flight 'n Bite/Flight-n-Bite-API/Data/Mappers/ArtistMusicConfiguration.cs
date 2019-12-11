using Flight_n_Bite_API.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Flight_n_Bite_API.Data.Mappers
{
    public class ArtistMusicConfiguration : IEntityTypeConfiguration<ArtistMusic>
    {
        public void Configure(EntityTypeBuilder<ArtistMusic> builder)
        {
            builder.ToTable("ArtistMusic");
            builder.HasKey(a => new { a.ArtistId, a.SongId });
        }
    }
}
