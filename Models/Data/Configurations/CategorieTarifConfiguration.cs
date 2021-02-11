using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Data.Configurations
{
    public class CategorieTarifConfiguration : IEntityTypeConfiguration<CategorieTarif>
    {
        public void Configure(EntityTypeBuilder<CategorieTarif> builder)
        {
            
        builder.Property(s => s.Categorie).HasMaxLength(12);
        builder.HasIndex(e => e.Categorie)
               .HasName("UnicityCategorie").IsUnique();
        builder.Property(s => s.Deleted).HasDefaultValue(false);

        }

    }
}
