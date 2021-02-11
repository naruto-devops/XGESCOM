using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Data.Configurations
{
    public class ParametresConfiguration : IEntityTypeConfiguration<Parametres>
    {
        public void Configure(EntityTypeBuilder<Parametres> builder)
        {

            builder.Property(s => s.INCCLI).HasDefaultValue(false);

            builder.Property(s => s.INCFRS).HasDefaultValue(false);
            builder.Property(s => s.NUMFRS).HasMaxLength(17);
            builder.Property(s => s.NUMCLI).HasMaxLength(17);
            builder.Property(s => s.ClientGen).HasMaxLength(13);


        }

    }
}
