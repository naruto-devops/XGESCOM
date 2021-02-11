using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models.Models
{
   public class Contact
    {   [Key]
        public int ID { get; set; }
        public string NomPrenom { get; set; }
        public string Fonction { get; set; }
        public string Adresse { get; set; }
        public string CodePostal { get; set; }
        public string Ville { get; set; }
        public string Pays { get; set; }
        public string Telephone { get; set; }
        public string Portable { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public int Type { get; set; }
        public bool Deleted { get; set; }
        //--LinkClients
        public Client Client { get; set; }
        public int? ClienttId { get; set; }

    }
}
