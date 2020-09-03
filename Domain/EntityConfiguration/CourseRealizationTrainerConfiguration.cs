using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.EntityConfiguration
{
    public class CourseRealizationTrainerConfiguration : IEntityTypeConfiguration<CourseRealizationTrainer>
    {
        public void Configure(EntityTypeBuilder<CourseRealizationTrainer> builder)
        {
            builder.HasKey(x => new { x.TrainerID, x.CourseRealizationID });

            builder.HasOne(x => x.Trainer).WithMany(x => x.CourseRealizationTrainers).HasForeignKey(x => x.TrainerID);

            builder.HasOne(x => x.CourseRealization).WithMany(x => x.CourseRealizationTrainers).HasForeignKey(x => x.CourseRealizationID);
        }
    }
}
