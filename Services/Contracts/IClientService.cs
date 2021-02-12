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
        List<Contact> GetcontactByClient(int clientId);
        Client Add(Client client);
        Client Update( Client client);
        bool CheckUnicCodification(string numero);
        bool Delete(int id);
        //bool CheckClient_ExistDocLig(int id);

        //FamilleTier GetfamTier(int id); 
    }
}