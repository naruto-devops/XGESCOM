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

        bool CheckUser_ExistCollaborateur(int id);
        bool Delete(int id);
    }
}

