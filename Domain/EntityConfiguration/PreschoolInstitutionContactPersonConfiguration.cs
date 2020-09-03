using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.EntityConfiguration
{
    public class PreschoolInstitutionContactPersonConfiguration : IEntityTypeConfiguration<PreschoolInstitutionContactPerson>
    {
        public void Configure(EntityTypeBuilder<PreschoolInstitutionContactPerson> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.PreschoolInstitution).WithMany(x => x.PreschoolInstitutionContactPeople).HasForeignKey(x => x.PreschoolInstitutionId);

            builder.Property(n => n.FirstName).HasMaxLength(50).IsRequired();

            builder.Property(l => l.LastName).HasMaxLength(50).IsRequired();

            builder.Property(x => x.Role).IsRequired();

            builder.Property(p => p.PhoneNumber).HasMaxLength(50);

            builder.Property(e => e.Email).HasMaxLength(50);

            builder.Property(n => n.Note).HasMaxLength(100);
        }
    }
}
