using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Contracts
{
   public  interface ICategorieTarifService
    {
        List<CategorieTarif> GetAll();
        CategorieTarif GetById(int id);
        CategorieTarif Add(CategorieTarif categorie);
        CategorieTarif Update(CategorieTarif categorie);
        Client CheckCategorie_ExistClient(int id);
        bool Delete(int id);
    }
}
