using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Models;
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
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            
        }


        public ModalitePaiement GetById(int id)
        {
            try
            {
                var res = _context.ModalitePaiements.FirstOrDefault(r => r.ID.Equals(id));
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ModalitePaiement Add(ModalitePaiement modalite)
        {
            try
            {
                _context.ModalitePaiements.Add(modalite);
                _context.SaveChanges();
                return modalite;
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
                var res = _context.ModalitePaiements.FirstOrDefault(r => r.ID.Equals(id));
                res.Deleted = true;
                if (res != null)
                {
                    _context.ModalitePaiements.Update(res);
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

        public ModalitePaiement Update(ModalitePaiement ModalitePaiement)
        {

            try
            {
                _context.Update(ModalitePaiement);
                _context.SaveChanges();
                return ModalitePaiement;
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
                    var client = _context.Clients.FirstOrDefault(r => r.ModalitePaiementId.Equals(id));
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
