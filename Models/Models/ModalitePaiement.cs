using Models.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    public class ModalitePaiement
    {
        [Key]
        public int Numero { get; set; }
        public string Intitule { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }


        public virtual IEnumerable<Client> Clients { get; set; }
    }
}
