using Flight_n_Bite_API.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flight_n_Bite_API.Data.Mappers
{
    public class PersonnelConfiguration : IEntityTypeConfiguration<Personnel>
    {
        public void Configure(EntityTypeBuilder<Personnel> builder)
        {
            builder.ToTable("Personnel");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.FirstName).IsRequired(true);

            builder.Property(p => p.Password).IsRequired(true);
        }
    }
}
