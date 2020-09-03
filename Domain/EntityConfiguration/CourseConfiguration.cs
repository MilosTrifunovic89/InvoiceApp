using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.EntityConfiguration
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(c => c.CourseName).HasMaxLength(200).IsRequired();

            builder.Property(c => c.CodeCourseZUOV).HasMaxLength(10);

            builder.Property(c => c.CursePasswordZUOV).HasMaxLength(10);

            builder.Property(x => x.CourseShortedName).IsRequired();

            builder.Property(x => x.DaysForInvoice).IsRequired();

            builder.Property(x => x.DaysForRealization).IsRequired();
        }
    }
}
