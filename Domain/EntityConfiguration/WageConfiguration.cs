using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.EntityConfiguration
{
    public class WageConfiguration : IEntityTypeConfiguration<Wage>
    {
        public void Configure(EntityTypeBuilder<Wage> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
