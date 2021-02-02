using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models.Models
{
    public class Client
    {
        [Key]
        public int CBMarque { get; set; }
        public string Numerotation { get; set; }
        public string Intitule { get; set; }
        public int Type { get; set; }
        public string NumeroPrincipale { get; set; }
        public string ContactPrincipale { get; set; }
        public string Complement { get; set; }
        public string CodePostal { get; set; }
        public string Ville { get; set; }
        public string CodeRegion { get; set; }
        public string Pays { get; set; }
        public string Raccourcis { get; set; }
        public int NumeroBanqueTier { get; set; }
        public string Ape { get; set; }
        public string MatriculeFiscale { get; set; }
        public string Siret { get; set; }
        public double Encours { get; set; }
        public string NumeroPayeur { get; set; }

        public int CategorieComptabilite { get; set; }
        public DateTime DateCreation { get; set; }
        public int Sommeil { get; set; }
        public int Depot { get; set; }
        public string Telephone { get; set; }
        public string Telecopie { get; set; }
        public string EMail { get; set; }
        public string SiteWeb { get; set; }
        
        public string Timbre { get; set; }
        public double TauxRemise { get; set; }
        public string CategorieTVA { get; set; }
        public string Categorie { get; set; }
        public int Etranger { get; set; }
      
        public double CoursDevise { get; set; }
        public string ADRESSELivraison { get; set; }
        public string CodePostalLivraison { get; set; }
        public string VilleLivraison { get; set; }
        public string PaysLivraison { get; set; }
        public string Qualite { get; set; }
        public string Adresse { get; set; }
        public string Commentaire { get; set; }
        public string Classement { get; set; }
        public string Jointe1 { get; set; }
        public string Jointe2 { get; set; }
        public string Incoterm { get; set; }
        public string CompteAuxiliaire { get; set; }
        public string ICE { get; set; }

        //Utilisateur -- createur---
        public Utilisateur CREATEUR { get; set; }
        public int? CREATEURId { get; set; }
        //Utilisateur -- modificateur---
        public Utilisateur MODIFICATEUR { get; set; }
        public int? MODIFICATEURId { get; set; }

        //categorieTarif -- link---
        public CategorieTarif CategorieTarif { get; set; }
        public int? CategorieTarifId { get; set; }


        //collaborateur --- link 
        public Collaborateur Collaborateur { get; set; }
        public int? CollaborateurId { get; set; }

        //Devise --- link 
        public Devise Devise { get; set; }
        public int? DeviseId { get; set; }

        //FamilleTier --- link 
        public FamilleTier FamilleTier { get; set; }
        public int? FamilleTierId { get; set; }

        //ModalitePaiement --- link 
        public ModalitePaiement ModalitePaiement { get; set; }
        public int? ModalitePaiementId { get; set; }

    }
}
