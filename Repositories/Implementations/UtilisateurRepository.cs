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

            }
            catch (Exception)
            {
                res = null;
            }

            return res;
        }

        public Utilisateur GetById(int id)
        {
            try
            {
                var res = _context.Utilisateurs.FirstOrDefault(r => r.ID.Equals(id));
                return res;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Utilisateur Add(Utilisateur Utilisateur)
        {
            try
            {
                _context.Utilisateurs.Add(Utilisateur);
                _context.SaveChanges();

            }
            catch (Exception)
            {
                return null;
            }
            return Utilisateur;
        }

        public bool Delete(int id)
        {

            try
            {
                var res = _context.Utilisateurs.FirstOrDefault(r => r.ID.Equals(id));
                if (res != null)
                {
                    _context.Utilisateurs.Remove(res);
                    _context.SaveChanges();
                }
                else
                    return false;


            }
            catch (Exception)
            {
                return false;

            }
            return true;
        }

        public Utilisateur Update(Utilisateur Utilisateur)
        {

            try
            {
                _context.Update(Utilisateur);
                _context.SaveChanges();

            }
            catch (Exception)
            {
                return null;

            }
            return Utilisateur;
        }
    
    }
}
