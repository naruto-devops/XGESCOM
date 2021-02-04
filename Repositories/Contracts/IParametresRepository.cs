using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Contracts
{
   public  interface IParametresRepository
    {
     Parametres GetAll();
     Parametres Update(Parametres parametres);
     bool UpdateNUMCLI(string numcli);
            
    }
}
