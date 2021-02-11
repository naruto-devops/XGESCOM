using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models.Models
{
   public  class FamilleTier
    {
        [Key]
        public int ID { get; set; }
        public string Code { get; set; }
        public string Libelle { get; set; }
        public bool   Exonere { get; set; }
        public bool Deleted { get; set; }
        public virtual IEnumerable<Client> Clients { get; set; }

        //categorieTarif -- link---
        public CategorieTarif CategorieTarif { get; set; }
        public int? CategorieTarifId { get; set; }

    }
}
