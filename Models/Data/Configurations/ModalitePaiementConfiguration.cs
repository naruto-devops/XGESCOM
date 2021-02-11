using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Data.Configurations
{
    public class ModalitePaiementConfiguration : IEntityTypeConfiguration<ModalitePaiement>
    {
        public void Configure(EntityTypeBuilder<ModalitePaiement> builder)
        {
            builder.Property(s => s.Intitule).HasMaxLength(45);
            builder.Property(s => s.Code).HasMaxLength(6);
            builder.Property(s => s.Description).HasMaxLength(200);
            builder.HasIndex(e => e.Code)
                   .HasName("UnicityCode").IsUnique();

            builder.Property(s => s.Deleted).HasDefaultValue(false);

        }
    }
}
