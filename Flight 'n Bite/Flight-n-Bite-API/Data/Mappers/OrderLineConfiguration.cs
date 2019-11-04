using Flight_n_Bite_API.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Flight_n_Bite_API.Data.Mappers
{
    public class OrderLineConfiguration : IEntityTypeConfiguration<OrderLine>
    {
        public void Configure(EntityTypeBuilder<OrderLine> builder)
        {
            builder.ToTable("OrderLine");

            builder.HasKey(ol => ol.Id);

            builder.HasOne(ol => ol.Product).WithMany();

            builder.Property(ol => ol.Amount).IsRequired();
        }
    }
}
