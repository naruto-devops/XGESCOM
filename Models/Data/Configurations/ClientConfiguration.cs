using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Data.Configurations
{
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {

            builder.Property(s => s.Numerotation).HasMaxLength(17);
            builder.Property(s => s.Intitule).HasMaxLength(35);
            builder.Property(s => s.NumeroPrincipale).HasMaxLength(13);
            builder.Property(s => s.ContactPrincipale).HasMaxLength(35);
            builder.Property(s => s.Complement).HasMaxLength(35);
            builder.Property(s => s.CodePostal).HasMaxLength(9);
            builder.Property(s => s.Ville).HasMaxLength(35);
            builder.Property(s => s.CodeRegion).HasMaxLength(25);
            builder.Property(s => s.Pays).HasMaxLength(35);
            builder.Property(s => s.Raccourcis).HasMaxLength(7);
            builder.Property(s => s.Ape).HasMaxLength(7);
            builder.Property(s => s.MatriculeFiscale).HasMaxLength(25);
            builder.Property(s => s.Siret).HasMaxLength(15);
            builder.Property(s => s.Encours).HasMaxLength(24);
            builder.Property(s => s.NumeroPayeur).HasMaxLength(17);
            builder.Property(s => s.Telephone).HasMaxLength(21);
            builder.Property(s => s.Telecopie).HasMaxLength(21);
            builder.Property(s => s.EMail).HasMaxLength(69);
            builder.Property(s => s.SiteWeb).HasMaxLength(69);
            builder.Property(s => s.Timbre).HasMaxLength(21);
            builder.Property(s => s.TauxRemise).HasMaxLength(18);
            builder.Property(s => s.CategorieTVA).HasMaxLength(7);
            builder.Property(s => s.Categorie).HasMaxLength(7);
            builder.Property(s => s.CoursDevise).HasMaxLength(18);
            builder.Property(s => s.ADRESSELivraison).HasMaxLength(70);
            builder.Property(s => s.CodePostalLivraison).HasMaxLength(10);
            builder.Property(s => s.VilleLivraison).HasMaxLength(35);
            builder.Property(s => s.PaysLivraison).HasMaxLength(35);
            builder.Property(s => s.Qualite).HasMaxLength(35);
            builder.Property(s => s.Adresse).HasMaxLength(60);
            builder.Property(s => s.Commentaire).HasMaxLength(100);
            builder.Property(s => s.Classement).HasMaxLength(35);
            builder.Property(s => s.Jointe1).HasMaxLength(150);
            builder.Property(s => s.Jointe2).HasMaxLength(150);
            builder.Property(s => s.CompteAuxiliaire).HasMaxLength(20);
            builder.Property(s => s.ICE).HasMaxLength(20);



            //builder.Property(s => s.CodePostal).HasMaxLength(5);
            //builder.HasIndex(e => e.CodeRegion)
            // .HasName("UnicityCodeRegion").IsUnique();
            //--Linkcategorietarif

            builder.HasOne(d => d.CategorieTarif)
                            .WithMany(s => s.Clients)
                            .HasForeignKey(s => s.CategorieTarifId);
            //--linkCollaborateur
            builder.HasOne(d => d.Collaborateur)
                               .WithMany(s => s.Clients)
                               .HasForeignKey(s => s.CollaborateurId);

            //--LinkDevise
            builder.HasOne(d => d.Devise)
                               .WithMany(s => s.Clients)
                               .HasForeignKey(s => s.DeviseId);


            //--LinkFamilleTier
            builder.HasOne(d => d.FamilleTier)
                               .WithMany(s => s.Clients)
                               .HasForeignKey(s => s.FamilleTierId);

            //--LinkModalitePaiement
            builder.HasOne(d => d.ModalitePaiement)
                               .WithMany(s => s.Clients)
                               .HasForeignKey(s => s.ModalitePaiementId);
            //--Link Utilisateurs
             builder.HasOne(d => d.Utilisateur)
                            .WithMany(s => s.Clients)
                            .HasForeignKey(s => s.CREATEURId);

            builder.HasOne(d => d.Utilisateur)
                            .WithMany(s => s.Clients)
                            .HasForeignKey(s => s.MODIFICATEURId);


        }
    }
}
