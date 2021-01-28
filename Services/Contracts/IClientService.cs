using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Contracts
{
    public interface IClientService
    {
        List<Client> GetAll();
        Client GetById(int id);
        Client Add(Client client);
        Client Update( Client client);
        bool CheckUnicCodification(string code);
        bool CheckClient_ExistDocLig(int id);
        bool Delete(int id);
        FamilleTier GetfamTier(int id); 
    }
}