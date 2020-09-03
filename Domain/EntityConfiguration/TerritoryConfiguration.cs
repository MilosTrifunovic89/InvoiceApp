using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.EntityConfiguration
{
    public class TerritoryConfiguration : IEntityTypeConfiguration<Territory>
    {
        public void Configure(EntityTypeBuilder<Territory> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.District).HasMaxLength(50).IsRequired();

            builder.Property(x => x.Municipality).HasMaxLength(50).IsRequired();

            builder.Property(x => x.Region).HasMaxLength(50).IsRequired();
        }
    }
}
