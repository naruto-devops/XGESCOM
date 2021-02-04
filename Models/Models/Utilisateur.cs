using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models.Models
{
   public class Utilisateur
    {   [Key]
            public int ID { get; set; }
        public string User { get; set; }
        public string ModePasse { get; set; }
        public string C_ModePasse { get; set; }
        public string Description { get; set; }
        public int Droit { get; set; }
        public DateTime Date_connexion { get; set; }



        //--Linkclient
        public virtual IEnumerable<Client> ClientModifies { get; set; }
        public virtual IEnumerable<Client> ClientCrees { get; set; }

        //--LinkCollaborateur
        public Collaborateur Collaborateur { get; set; }
        public int? CollaborateurId { get; set; }
    }
}
