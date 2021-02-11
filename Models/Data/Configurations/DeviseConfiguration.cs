using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Data.Configurations
{
    public class DeviseConfiguration : IEntityTypeConfiguration<Devise>
    {
        public void Configure(EntityTypeBuilder<Devise> builder)
        {

            builder.Property(s => s.DEVISE).HasMaxLength(12);
            builder.HasIndex(e => e.DEVISE)
               .HasName("UnicityDEVISE").IsUnique();
            builder.Property(s => s.CODEISO).HasMaxLength(12);
            builder.Property(s => s.CODEBANQUE).HasMaxLength(12);
            builder.Property(s => s.LIBELLE).HasMaxLength(50);
            builder.Property(s => s.SYMBOLE).HasMaxLength(12);
            builder.Property(s => s.DECIMALE).HasMaxLength(1);
            builder.Property(s => s.COURS).HasMaxLength(18);

            builder.Property(s => s.Deleted).HasDefaultValue(false);

        }
    }
}
