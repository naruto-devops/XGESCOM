using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Contracts
{
    public interface IClientRepository
    {
        List<Client> GetAll();
        Client GetById(int id);
        Client Add(Client client);
        Client Update(Client client);
        Client GetByDocLig(int id);
        bool Delete(int id);
        FamilleTier GetFamilleTier(int id);
    }
}
