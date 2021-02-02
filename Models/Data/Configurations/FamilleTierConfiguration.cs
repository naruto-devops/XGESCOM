using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Data.Configurations
{
   public class FamilleTierConfiguration : IEntityTypeConfiguration<FamilleTier>
    {
        public void Configure(EntityTypeBuilder<FamilleTier> builder)
        {

            builder.Property(s => s.Code).HasMaxLength(19);
            builder.HasIndex(e => e.Code)
                   .HasName("UnicityCode").IsUnique();
            builder.Property(s => s.Libelle).HasMaxLength(19);
          

            //--linkCategorieTarif
            builder.HasOne(d => d.CategorieTarif)
                           .WithMany(s => s.FamilleTier)
                           .HasForeignKey(s => s.CategorieTarifId);
        }
    
    
    }
}
