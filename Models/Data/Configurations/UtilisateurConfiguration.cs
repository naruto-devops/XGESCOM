using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Data.Configurations
{
   public  class UtilisateurConfiguration : IEntityTypeConfiguration<Utilisateur>
    {
        public void Configure(EntityTypeBuilder<Utilisateur> builder)
        {
            builder.Property(s => s.User).HasMaxLength(12);
            builder.HasIndex(e => e.User)
                   .HasName("UnicityNomUtilisateur").IsUnique();
            builder.Property(s => s.ModePasse).HasMaxLength(12);
            builder.Property(s => s.C_ModePasse).HasMaxLength(12);
            builder.Property(s => s.Description).HasMaxLength(50);
            builder.Property(s => s.Deleted).HasDefaultValue(false);

        }
 
    }
}
