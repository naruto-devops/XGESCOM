using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Models.Data.Configurations;
using Models.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace Models.Data
{
    public class XSoftContext : DbContext
    {
        public XSoftContext(DbContextOptions<XSoftContext> options) : base(options)
        {
        }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<CategorieTarif> CategorieTarifs { get; set; }
        public virtual DbSet<Devise> Devises { get; set; }
        public virtual DbSet<Collaborateur> Collaborateurs { get; set; }
        public virtual DbSet<FamilleTier> FamilleTiers { get; set; }
        public virtual DbSet<Utilisateur> Utilisateurs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ClientConfiguration());
            modelBuilder.ApplyConfiguration(new DeviseConfiguration());
        }
    }
}
