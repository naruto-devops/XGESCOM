using Models.Models;
using Repositories.Contracts;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Implementations
{
   public  class UtilisateurServices : IUtilisateurService
    {
        IUtilisateurRepository _UtilisateurRepository;

        public UtilisateurServices(IUtilisateurRepository uti)
        {
            _UtilisateurRepository = uti;
        }

        public bool CheckUser_ExistCollaborateur(int id)
        {
            //var uti = _UtilisateurRepository.GetByClient(id);
            //return uti != null;
            return true;
        }

        public List<Utilisateur> GetAll()
        {
            List<Utilisateur> result = new List<Utilisateur>();
            result = _UtilisateurRepository.GetAll();
            return result;
        }

        public Utilisateur GetById(int id)
        {
            return _UtilisateurRepository.GetById(id);
        }

        public Utilisateur Add(Utilisateur uti)
        {
            _UtilisateurRepository.Add(uti);

            return uti;

        }

        public Utilisateur Update(Utilisateur uti)
        {
            _UtilisateurRepository.Update(uti);
            return uti;
        }

        public bool Delete(int id)
        {
            return _UtilisateurRepository.Delete(id);

        }
    }
}
