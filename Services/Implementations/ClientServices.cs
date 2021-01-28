using Models.Models;
using Repositories.Contracts;
using Services.Contracts;
using Services.Implementations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class ClientServices : IClientService
    {

        IClientRepository _ClientRepository;

        IParametresService _parametresService;

        public ClientServices(IClientRepository client, IParametresService parametres)
        {
            _ClientRepository = client;

            _parametresService = parametres;
        }

        public bool CheckUnicCodification(string code)
        {
            List<Client> _listeClient = new List<Client>();
            _listeClient = _ClientRepository.GetAll();
            var res = false;
           foreach (Client client in _listeClient)
            {
                if (client.Intitule == code)
                {
                    res = true;
                    break;
                }                    
            }

            return res;
        }

        public List<Client> GetAll()
        {
            List<Client> result = new List<Client>();
            result = _ClientRepository.GetAll();
            return result;
        }
        public Client GetById(int id)
        {
            return _ClientRepository.GetById(id);
        }


        public Client Add(Client client)
        {
            Client result = new Client();

            var codification = _parametresService.Check_IncrementCodification();
            if (codification == 0)
            {
                if (!CheckUnicCodification(client.Numero))
                {
                    _ClientRepository.Add(client);
                    result = client;

                }
                else
                {
                    result = null;
                }

            }
            else if (codification == 1)  
            {
                Parametres parametre = _parametresService.GetAll();
                string codeClient = parametre.NUMCLI;

                client.Numero = codeClient.IncrementCode();
                result = _ClientRepository.Add(client);
                parametre.NUMCLI = client.Numero;
                _parametresService.UpdateNUMCLI(codeClient);
            }

            return result;
            

        }

        public Client Update( Client client)
        {
            _ClientRepository.Update( client);
            return client;
        }

        public bool Delete(int id)
        {
            return _ClientRepository.Delete(id);

        }

        public bool CheckClient_ExistDocLig( int id)
        {
            var result = _ClientRepository.GetByDocLig(id);
            return result != null;
        }

        public FamilleTier GetfamTier(int id)
        {
            return _ClientRepository.GetFamilleTier(id);
        }

    }
}
