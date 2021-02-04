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
        public XSoftContext()
        {
        }

        public XSoftContext(DbContextOptions<XSoftContext> options) : base()
        {
        }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<CategorieTarif> CategorieTarifs { get; set; }
        public virtual DbSet<Devise> Devises { get; set; }
        public virtual DbSet<Collaborateur> Collaborateurs { get; set; }
        public virtual DbSet<FamilleTier> FamilleTiers { get; set; }
        public virtual DbSet<Utilisateur> Utilisateurs { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<ModalitePaiement> ModalitePaiements { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                  .SetBasePath(Directory.GetCurrentDirectory())
                  .AddJsonFile("appsettings.json")
                  .Build();
                var connectionString = configuration.GetConnectionString("DefaultConnection");
                optionsBuilder.UseSqlServer(connectionString);
            }

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ClientConfiguration());
            modelBuilder.ApplyConfiguration(new DeviseConfiguration());
            modelBuilder.ApplyConfiguration(new CategorieTarifConfiguration());
            modelBuilder.ApplyConfiguration(new FamilleTierConfiguration());
            modelBuilder.ApplyConfiguration(new UtilisateurConfiguration());
            modelBuilder.ApplyConfiguration(new CollaborateurConfiguration());
            modelBuilder.ApplyConfiguration(new ContactConfiguration());
            modelBuilder.ApplyConfiguration(new ModalitePaiementConfiguration());
        }
    }
}
