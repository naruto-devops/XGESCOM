using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Data.Configurations
{
    class CollaborateurConfiguration : IEntityTypeConfiguration<Collaborateur>
    {
        public void Configure(EntityTypeBuilder<Collaborateur> builder)
        {

            builder.Property(s => s.Nom).HasMaxLength(35);
            builder.Property(s => s.Prenom).HasMaxLength(35);
            builder.Property(s => s.Fonction).HasMaxLength(35);
            builder.Property(s => s.Adresse).HasMaxLength(60);
            builder.Property(s => s.CodePostal).HasMaxLength(9);
            builder.Property(s => s.Ville).HasMaxLength(35);
            builder.Property(s => s.Service).HasMaxLength(35);
            builder.Property(s => s.Telephone).HasMaxLength(21);
            builder.Property(s => s.EMail).HasMaxLength(69);
            builder.Property(s => s.Matricule).HasMaxLength(11);

            builder.Property(s => s.Deleted).HasDefaultValue(false);
        }
    }
}
