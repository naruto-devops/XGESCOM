using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Contracts
{
    public interface IUtilisateurRepository
    {
        List<Utilisateur> GetAll();
        Utilisateur GetById(int id);
        Utilisateur Add(Utilisateur Utilisateur);
        Utilisateur Update(Utilisateur Utilisateur);
        bool Delete(int id);
        Collaborateur GetUserByCollaborator(int id);
        Client GetCreatorByClient(int id);
        Client GetModificatorByClient(int id);
    }
}
