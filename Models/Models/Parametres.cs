using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models.Models
{
   public  class Parametres
    {   [Key]
        public int ID { get; set; }
        public bool INCFRS { get; set; }
        public bool INCCLI { get; set; }
        public string NUMFRS { get; set; }
        public string NUMCLI { get; set; }
        public string ClientGen { get; set; }


    }
}
