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
            try
            {
                _UtilisateurRepository = uti;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

       

        public List<Utilisateur> GetAll()
        {
            List<Utilisateur> result = new List<Utilisateur>();
            try
            {
                result = _UtilisateurRepository.GetAll();
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Utilisateur GetById(int id)
        {
            Utilisateur result = new Utilisateur();


            try
            {
                result = _UtilisateurRepository.GetById(id);
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Utilisateur Add(Utilisateur uti)
        {
            try
            {
                _UtilisateurRepository.Add(uti);
                return uti;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public Utilisateur Update(Utilisateur uti)
        {
            try
            {
                _UtilisateurRepository.Update(uti);
                return uti;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool Delete(int id)
        {
            var userCreateur = CheckCreator_ExistClient(id);
            var userModificateur = CheckModificator_ExistClient(id);
            var UserCollaborateur = CheckUser_ExistCollaborateur(id);

            var result = false;
            if ((UserCollaborateur == null)&&((userCreateur==null)&&(userModificateur==null)))
            {
                result = true;
                _UtilisateurRepository.Delete(id);
            }
            
            return result;
           

        }
        public Collaborateur CheckUser_ExistCollaborateur(int id)
        {
            Collaborateur result = new Collaborateur();
            try
            {
                result = _UtilisateurRepository.GetUserByCollaborator(id);
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public Client CheckCreator_ExistClient(int id)
        {
            Client result = new Client ();
            try
            {
               result=  _UtilisateurRepository.GetCreatorByClient(id);
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Client CheckModificator_ExistClient(int id)
        {
            Client result = new Client();
            try
            {
                result = _UtilisateurRepository.GetModificatorByClient(id);
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

      
    }
}
