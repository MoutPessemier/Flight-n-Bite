using Flight_n_Bite_API.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Flight_n_Bite_API.Data.Mappers
{
    public class PersonnelConfiguration : IEntityTypeConfiguration<Personnel>
    {
        public void Configure(EntityTypeBuilder<Personnel> builder)
        {
            builder.ToTable("Personnel");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.UserName).IsRequired(true);
        }
    }
}
