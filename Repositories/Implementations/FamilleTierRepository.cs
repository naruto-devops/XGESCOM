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
   public  class FamilleTierRepository: IFamilleTierRepository

    {
        XSoftContext _context;
        public FamilleTierRepository(XSoftContext context)
        {
            _context = context;
        }


        public List<FamilleTier> GetAll()
        {
            var res = new List<FamilleTier>();
            try
            {
                res = _context.FamilleTiers.ToList();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            
        }


        public FamilleTier GetById(int id)
        {
            try
            {
                var res = _context.FamilleTiers.FirstOrDefault(r => r.ID.Equals(id));
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public FamilleTier Add(FamilleTier famille)
        {
            try
            {
                _context.FamilleTiers.Add(famille);
                _context.SaveChanges();
                return famille;
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
                var res = _context.FamilleTiers.FirstOrDefault(r => r.ID.Equals(id));
                res.Deleted = true;
                if (res != null)
                {
                    _context.FamilleTiers.Update(res);
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

        public FamilleTier Update(FamilleTier FamilleTier)
        {

            try
            {
                _context.Update(FamilleTier);
                _context.SaveChanges();
                return FamilleTier;

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
                    var client = _context.Clients.FirstOrDefault(r => r.FamilleTierId.Equals(id));
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
