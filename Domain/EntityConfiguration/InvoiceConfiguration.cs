using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.EntityConfiguration
{
    public class InvoiceConfiguration : IEntityTypeConfiguration<Invoice>
    {
        public void Configure(EntityTypeBuilder<Invoice> builder)
        {
            builder.HasKey(x => new { x.Id, x.TrainerID, x.YearID });

            builder.HasOne(x => x.Trainer).WithMany(x => x.Invoices).HasForeignKey(x => x.TrainerID);

            builder.HasOne(x => x.Wage).WithMany(x => x.Invoices).HasForeignKey(x => x.WageID);
        }
    }
}
