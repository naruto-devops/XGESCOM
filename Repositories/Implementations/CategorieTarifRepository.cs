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

            }
            catch (Exception)
            {
                res = null;
            }

            return res;
        }

        public CategorieTarif GetById(int id)
        {
            try
            {
                var res = _context.CategorieTarifs.FirstOrDefault(r => r.ID.Equals(id));
                return res;
            }
            catch (Exception)
            {
                return null;
            }
        }
       
        public CategorieTarif Add(CategorieTarif categorie)
        {
            try
            {
                _context.CategorieTarifs.Add(categorie);
                _context.SaveChanges();

            }
            catch (Exception)
            {
                return null;
            }
            return categorie;
        }

        public bool Delete(int id)
        {

            try
            {
                var res = _context.CategorieTarifs.FirstOrDefault(r => r.ID.Equals(id));
                if (res != null)
                {
                    _context.CategorieTarifs.Remove(res);
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

        public CategorieTarif Update(CategorieTarif categorieTarif)
        {

            try
            {
                _context.Update(categorieTarif);
                _context.SaveChanges();

            }
            catch (Exception)
            {
                return null;

            }
            return categorieTarif;
        }

        //public CategorieTarif GetByClient(int id)
        //{
        //    var res = new CategorieTarif();
        //    try
        //    {
        //        using (var db = new XSoftContext())
        //        {
        //            var result = db.Clients.Where(r => r.CategorieTarifId.Equals(id)).FirstOrDefault();


        //        }


        //    }
        //    catch (Exception)
        //    {
        //        return null;

        //    }
        //    return res;
        //}


    }
}
