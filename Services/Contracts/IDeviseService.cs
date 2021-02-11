using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Contracts
{
   public interface IDeviseService
    {
        List<Devise> GetAll();
        Devise GetById(int id);
        Devise Add(Devise cbl);
        Devise Update(Devise cbl);

       Client CheckDevise_ExistClient(int id);
        bool Delete(int id);
    }
}
