using Microsoft.Extensions.Configuration;
using Models.Models;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Microsoft.Data.SqlClient;
using Dapper;
using System.Linq;
using Models.Data;

namespace Repositories.Implementations
{
   public  class CategorieTarifRepository : ICategorieTarifRepository
    {
        XSoftContext _context;
        public CategorieTarifRepository(XSoftContext context)
        {
            _context = context;
        }

        public List<CategorieTarif> GetAll()
        {
            var res = new List<CategorieTarif>();
            try
            {
                res = _context.CategorieTarifs.ToList();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }

           
        }

        public CategorieTarif GetById(int id)
        {
            try
            {
                var res = _context.CategorieTarifs.FirstOrDefault(r => r.ID.Equals(id));
                return res;
            }
            catch (Exception ex)
            {
                 throw ex;
            }
        }
       
        public CategorieTarif Add(CategorieTarif categorie)
        {
            try
            {
                _context.CategorieTarifs.Add(categorie);
                _context.SaveChanges();
                return categorie;
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
                var res = _context.CategorieTarifs.FirstOrDefault(r => r.ID.Equals(id));
                res.Deleted = true;
                if (res != null)
                {
                    _context.CategorieTarifs.Update(res);
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

        public CategorieTarif Update(CategorieTarif categorieTarif)
        {

            try
            {
                _context.Update(categorieTarif);
                _context.SaveChanges();
                return categorieTarif;
            }
            catch (Exception ex)
            {
                throw ex;

            }
            
        }

        public Client GetByClient(int id)
        {           
            try
            {
                using (var db = new XSoftContext())
                {
                     var client = _context.Clients.FirstOrDefault(r => r.CategorieTarifId.Equals(id));
                    return client;
                }               
            }
            catch (Exception ex)
            {
                throw ex;
            }
          
        }


    }
}
