using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.EntityConfiguration
{
    public class PreschoolInstitutionConfiguration : IEntityTypeConfiguration<PreschoolInstitution>
    {
        public void Configure(EntityTypeBuilder<PreschoolInstitution> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Territory).WithMany(x => x.PreschoolInstitutions).HasForeignKey(x => x.TerritoryId);

            builder.Property(x => x.PIName).HasMaxLength(100);
        }
    }
}
