using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models.Models
{
   public class Collaborateur
    {
        [Key]
        public int ID { get; set; }
        public string    Nom { get; set; }
        public string   Prenom { get; set; }
        public string    Fonction { get; set; }
        public string    Adresse { get; set; }
        public string    CodePostal { get; set; }
        public string    Ville { get; set; }
        public string    Service { get; set; }
        public string   Telephone { get; set; }
        public string    EMail { get; set; }
        public string    Matricule { get; set; }
        public int      Type { get; set; }
        public bool Deleted { get; set; }

        public virtual IEnumerable<Client> Clients { get; set; }
        public Utilisateur Utilisateur { get; set; }
        public int? UtilisateurId { get; set; }
       
    }
}
