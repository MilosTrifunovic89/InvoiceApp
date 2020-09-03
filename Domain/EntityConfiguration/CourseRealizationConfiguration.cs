using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.EntityConfiguration
{
    public class CourseRealizationConfiguration : IEntityTypeConfiguration<CourseRealization>
    {
        public void Configure(EntityTypeBuilder<CourseRealization> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.PreschoolInstitution).WithMany(x => x.CourseRealizations).HasForeignKey(x => x.PreschoolInstitutionID);

            builder.HasOne(x => x.Course).WithMany(x => x.CourseRealizations).HasForeignKey(x => x.CourseID);

            builder.Property(c => c.ZUOVPassword).HasMaxLength(10);
        }
    }
}
