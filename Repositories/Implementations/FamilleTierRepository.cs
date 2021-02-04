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

            }
            catch (Exception)
            {
                res = null;
            }

            return res;
        }


        public FamilleTier GetById(int id)
        {
            try
            {
                var res = _context.FamilleTiers.FirstOrDefault(r => r.ID.Equals(id));
                return res;
            }
            catch (Exception)
            {
                return null;
            }
        }

        //public FamilleTier GetByClient(int id)
        //{
        //    var res = new FamilleTier();
        //    try
        //    {
        //        using (var db = new XSoftContext())
        //        {
        //            var result = db.Clients.Where(r => r.FamilleTierId.Equals(id)).FirstOrDefault();


        //        }


        //    }
        //    catch (Exception)
        //    {
        //        return null;

        //    }
        //    return res;
        //}

        public FamilleTier Add(FamilleTier dvs)
        {
            try
            {
                _context.FamilleTiers.Add(dvs);
                _context.SaveChanges();

            }
            catch (Exception)
            {
                return null;
            }
            return dvs;
        }

        public bool Delete(int id)
        {

            try
            {
                var res = _context.FamilleTiers.FirstOrDefault(r => r.ID.Equals(id));
                if (res != null)
                {
                    _context.FamilleTiers.Remove(res);
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

        public FamilleTier Update(FamilleTier FamilleTier)
        {

            try
            {
                _context.Update(FamilleTier);
                _context.SaveChanges();

            }
            catch (Exception)
            {
                return null;

            }
            return FamilleTier;
        }
    }
}
