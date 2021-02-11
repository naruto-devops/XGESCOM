using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models.Models
{
    public class Devise
    {
        [Key]
        public int ID { get; set; }
        public string DEVISE { get; set; }
        public string CODEISO { get; set; }
        public string CODEBANQUE { get; set; }
        public string LIBELLE { get; set; }
        public string SYMBOLE { get; set; }
        public int DECIMALE { get; set; }
        public double COURS { get; set; }
        public bool Deleted { get; set; }
        public virtual IEnumerable<Client> Clients { get; set; }
    }
}
