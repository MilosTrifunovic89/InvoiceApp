using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.EntityConfiguration
{
    public class InvoiceItemConfiguration : IEntityTypeConfiguration<InvoiceItem>
    {
        public void Configure(EntityTypeBuilder<InvoiceItem> builder)
        {
            builder.HasKey(x => new { x.InvoiceID, x.YearID, x.TrainerID, x.CourseRealizationID });

            builder.HasOne(x => x.CourseRealization).WithMany(x => x.InvoiceItems).HasForeignKey(x => x.CourseRealizationID);

            builder.HasOne(x => x.Invoice).WithMany(x => x.InvoiceItems).HasForeignKey(x => new { x.InvoiceID, x.TrainerID, x.YearID });

            builder.Property(x => x.Description).HasMaxLength(100);
        }
    }
}
