using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
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
    public class DeviseRepository : IDeviseRepository
    {
       
        XSoftContext _context;
        public DeviseRepository(XSoftContext context)
        {
            _context = context;
        }


        public List<Devise> GetAll()
        {
            var res = new List<Devise>();
            try
            {
                res = _context.Devises.ToList();

            }
            catch (Exception)
            {
                res = null;
            }

            return res;
        }


        public Devise GetById(int id)
        {
            try
            {
                var res = _context.Devises.FirstOrDefault(r => r.ID.Equals(id));
                return res;
            }
            catch (Exception)
            {
                return null;
            }
        }

        //public Devise GetByClient(int id)
        //{
        //    var res = new Devise();
        //    try
        //    {
        //        using (var db = new XSoftContext())
        //        {
        //            var result = db.Clients.Where(r => r.DeviseId.Equals(id)).FirstOrDefault();


        //        }


        //    }
        //    catch (Exception)
        //    {
        //        return null;

        //    }
        //    return res;
        //}

        public Devise Add(Devise dvs)
        {
            try
            {
                _context.Devises.Add(dvs);
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
                var res = _context.Devises.FirstOrDefault(r => r.ID.Equals(id));
                if (res != null)
                {
                    _context.Devises.Remove(res);
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

        public Devise Update(Devise devise)
        {

            try
            {
                _context.Update(devise);
                _context.SaveChanges();

            }
            catch (Exception)
            {
                return null;

            }
            return devise;
        }
    }
}
