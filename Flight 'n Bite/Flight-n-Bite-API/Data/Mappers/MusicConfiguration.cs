using Flight_n_Bite_API.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Flight_n_Bite_API.Data.Mappers
{
    public class MusicConfiguration : IEntityTypeConfiguration<Music>
    {
        public void Configure(EntityTypeBuilder<Music> builder)
        {
            builder.ToTable("Music");

            builder.Property(m => m.Album)
                .IsRequired(true);

            builder.HasOne(m => m.Artist)
                .WithMany();

            builder.Property(m => m.CoverUri)
                .IsRequired(true);

            builder.Property(m => m.Id)
                .IsRequired(true);

            builder.Property(m => m.Title)
                .IsRequired(true);
        }
    }
}
