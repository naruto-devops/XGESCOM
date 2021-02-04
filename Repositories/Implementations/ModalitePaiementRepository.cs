using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Models;
using Models.Data;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Repositories.Implementations
{
  public   class ModalitePaiementRepository : IModalitePaiementRepository
    {
        XSoftContext _context;
        public ModalitePaiementRepository(XSoftContext context)
        {
            _context = context;
        }


        public List<ModalitePaiement> GetAll()
        {
            var res = new List<ModalitePaiement>();
            try
            {
                res = _context.ModalitePaiements.ToList();

            }
            catch (Exception)
            {
                res = null;
            }

            return res;
        }


        public ModalitePaiement GetById(int id)
        {
            try
            {
                var res = _context.ModalitePaiements.FirstOrDefault(r => r.ID.Equals(id));
                return res;
            }
            catch (Exception)
            {
                return null;
            }
        }

        //public ModalitePaiement GetByClient(int id)
        //{
        //    var res = new ModalitePaiement();
        //    try
        //    {
        //        using (var db = new XSoftContext())
        //        {
        //            var result = db.Clients.Where(r => r.ModalitePaiementId.Equals(id)).FirstOrDefault();


        //        }


        //    }
        //    catch (Exception)
        //    {
        //        return null;

        //    }
        //    return res;
        //}

        public ModalitePaiement Add(ModalitePaiement dvs)
        {
            try
            {
                _context.ModalitePaiements.Add(dvs);
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
                var res = _context.ModalitePaiements.FirstOrDefault(r => r.ID.Equals(id));
                if (res != null)
                {
                    _context.ModalitePaiements.Remove(res);
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

        public ModalitePaiement Update(ModalitePaiement ModalitePaiement)
        {

            try
            {
                _context.Update(ModalitePaiement);
                _context.SaveChanges();

            }
            catch (Exception)
            {
                return null;

            }
            return ModalitePaiement;
        }
    }
}
