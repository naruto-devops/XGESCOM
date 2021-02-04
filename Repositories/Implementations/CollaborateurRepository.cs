using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Models.Data;
using Models.Models;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Repositories.Implementations
{
   public class CollaborateurRepository : ICollaborateurRepository
    {
        XSoftContext _context;
        public CollaborateurRepository(XSoftContext context)
        {
            _context = context;
        }

        public List<Collaborateur> GetAll()
        {
            var res = new List<Collaborateur>();
            try
            {
                res = _context.Collaborateurs.ToList();
                
            }
            catch (Exception)
            {
                res = null;
            }

            return res;
        }

        public Collaborateur GetById(int id)
        {
            try
            {
                var res = _context.Collaborateurs.FirstOrDefault(r => r.ID.Equals(id));
                return res;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Collaborateur Add(Collaborateur collaborateur)
        {
            try
            {
                _context.Collaborateurs.Add(collaborateur);
                _context.SaveChanges();

            }
            catch (Exception)
            {
                return null;
            }
            return collaborateur;
        }

        public bool Delete(int id)
        {

            try
            {
                var res = _context.Collaborateurs.FirstOrDefault(r => r.ID.Equals(id));
                if (res != null)
                {
                    _context.Collaborateurs.Remove(res);
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

        public Collaborateur Update(Collaborateur collaborateur)
        {

            try
            {
                _context.Update(collaborateur);
                _context.SaveChanges();

            }
            catch (Exception)
            {
                return null;

            }
            return collaborateur;
        }
    }
}
