using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Contracts
{
    public interface IParametresService
    {   Parametres GetAll();
        Parametres Update(Parametres parametre);
        int Check_IncrementCodification();
        bool UpdateNUMCLI(string numcli);
        
    }
}
