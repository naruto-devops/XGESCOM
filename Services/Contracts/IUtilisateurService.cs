using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Contracts
{
   public  interface IUtilisateurService
    {
        List<Utilisateur> GetAll();
        Utilisateur GetById(int id);
        Utilisateur Add(Utilisateur cbl);
        Utilisateur Update(Utilisateur cbl);
        bool Delete(int id);

        Collaborateur CheckUser_ExistCollaborateur(int id);

        Client CheckModificator_ExistClient(int id);
        Client CheckCreator_ExistClient(int id);
        
    }
}

