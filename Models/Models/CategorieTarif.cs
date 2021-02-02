using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models.Models
{
    public class CategorieTarif
    {
        [Key]
        public int Numero { get; set; }
        public string Categorie { get; set; }
        public int PrixTTC { get; set; }

        public virtual IEnumerable<Client> Clients { get; set; }
        public virtual IEnumerable<FamilleTier> FamilleTiers { get; set; }
    }
}
