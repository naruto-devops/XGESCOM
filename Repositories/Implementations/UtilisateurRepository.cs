using Dapper;
using Microsoft.Extensions.Configuration;
using Models.Data;
using Models.Models;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Repositories.Implementations
{
   public class UtilisateurRepository :IUtilisateurRepository
    {
        XSoftContext _context;
        public UtilisateurRepository(XSoftContext context)
        {
            _context = context;
        }

        public List<Utilisateur> GetAll()
        {
            var res = new List<Utilisateur>();
            try 
            {
                res = _context.Utilisateurs.ToList();
                return res;

            }
            catch (Exception ex)
            {
                throw ex;

            }

        }

        public Utilisateur GetById(int id)
        {
            try
            {
                var res = _context.Utilisateurs.FirstOrDefault(r => r.ID.Equals(id));
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Utilisateur Add(Utilisateur Utilisateur)
        {
            try
            {
                _context.Utilisateurs.Add(Utilisateur);
                _context.SaveChanges();
                return Utilisateur;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Delete(int id)
        {

            try
            {
                var res = _context.Utilisateurs.FirstOrDefault(r => r.ID.Equals(id));
                res.Deleted = true;
                if (res != null)
                {
                    _context.Utilisateurs.Update(res);
                    _context.SaveChanges();
                    return true;
                }
                else
                    return false;


            }
            catch (Exception ex)
            {
                throw ex;

            }
           
        }

        public Utilisateur Update(Utilisateur Utilisateur)
        {

            try
            {
                _context.Update(Utilisateur);
                _context.SaveChanges();
                return Utilisateur;
            }
            catch (Exception ex)
            {
                throw ex;

            }
           
        }

        public Client GetCreatorByClient(int id)
        {
            try
            {
                using (var db = new XSoftContext())
                {
                    var res = db.Clients.Where(r => r.CREATEURId.Equals(id)).FirstOrDefault();
                    return res;
                }
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }
        public Client GetModificatorByClient(int id)
        {
           
            try
            {
                using (var db = new XSoftContext())
                {
                    var res = db.Clients.Where(r => r.MODIFICATEURId.Equals(id)).FirstOrDefault();
                    return res;
                }
            }
            catch (Exception ex)
            {
                throw ex;

            }
            
        }

       public Collaborateur GetUserByCollaborator(int id)
        {

            try
            {
                using (var db = new XSoftContext())
                {
                    var res = db.Collaborateurs.Where(r => r.UtilisateurId.Equals(id)).FirstOrDefault();
                    return res;
                }
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }
    }
}
