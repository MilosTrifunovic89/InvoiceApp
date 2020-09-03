using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.EntityConfiguration
{
    public class TrainerConfiguration : IEntityTypeConfiguration<Trainer>
    {
        public void Configure(EntityTypeBuilder<Trainer> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Territory).WithMany(x => x.Trainers).HasForeignKey(x => x.TerritoryId);

            builder.Property(f => f.FirstName).HasMaxLength(50).IsRequired();

            builder.Property(l => l.LastName).HasMaxLength(50).IsRequired();

            builder.Property(a => a.Address).HasMaxLength(100);

            builder.Property(a => a.PhoneNumber).HasMaxLength(50);

            builder.Property(a => a.Email).HasMaxLength(100);

            builder.Property(a => a.Bank).HasMaxLength(50);

            builder.Property(a => a.AccountNumber).HasMaxLength(50);//izmeniti na tacan broj karaktera

            builder.Property(n => n.Note).HasMaxLength(100);
        }
    }
}
