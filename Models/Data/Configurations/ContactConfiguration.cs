using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Data.Configurations
{
    public class ContactConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            
                builder.Property(s => s.NomPrenom).HasMaxLength(35);

                builder.Property(s => s.Fonction).HasMaxLength(35);
                builder.Property(s => s.Adresse).HasMaxLength(35);
                builder.Property(s => s.CodePostal).HasMaxLength(10);
                builder.Property(s => s.Ville).HasMaxLength(35);
                builder.Property(s => s.Telephone).HasMaxLength(35);
                builder.Property(s => s.Portable).HasMaxLength(35);
            builder.Property(s => s.Fax).HasMaxLength(35);
            builder.Property(s => s.Email).HasMaxLength(35);
            builder.Property(s => s.Type).HasMaxLength(1);

            builder.Property(s => s.Deleted).HasDefaultValue(false);
        }
    }
}
