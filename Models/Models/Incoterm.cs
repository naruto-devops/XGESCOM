using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models.Models
{
   public  class Incoterm
    {
        [Key]
        public int Numero { get; set; }
        public string Code { get; set; }
        public string Libelle { get; set; }
        public DateTime DateCreation { get; set; }
        public DateTime DateModification { get; set; }
        public int Utilisateur { get; set; }

    }
}
