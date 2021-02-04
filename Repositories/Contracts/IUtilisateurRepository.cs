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
       // Utilisateur GetByClient(int id);
        Utilisateur Add(Utilisateur Utilisateur);
        Utilisateur Update(Utilisateur Utilisateur);
        bool Delete(int id);
    }
}
