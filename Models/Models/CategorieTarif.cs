using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models.Models
{
    public class CategorieTarif
    {
        [Key]
        public int ID { get; set; }
        public string Categorie { get; set; }
        public bool PrixTTC { get; set; }
        public bool Deleted { get; set; }
        public virtual IEnumerable<Client> Clients { get; set; }
        public virtual IEnumerable<FamilleTier> FamilleTiers { get; set; }
    }
}
