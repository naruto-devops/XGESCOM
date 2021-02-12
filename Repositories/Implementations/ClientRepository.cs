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
    public class ClientRepository : IClientRepository
    {
        XSoftContext _context;
        public ClientRepository(XSoftContext context)
        {
            _context = context;
        }

        public List<Client> GetAll()
        {
            var res = new List<Client>();
            try
            {
                res = _context.Clients.Where(a => a.Deleted == false).ToList();
                return res;

            }
            catch (Exception ex)
            {
                throw ex;
            }

            
        }

        public Client GetById(int id)
        {
            try
            {
                var res = _context.Clients.FirstOrDefault(r => r.ID.Equals(id));
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<Contact> GetByClient(int ClientId)
        {
            var res = new List<Contact>();
            try
            {
                res = _context.Contacts.Where(r => r.ClienttId.Equals(ClientId)).ToList();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Client Add(Client Client)
        {
            try
            {
                _context.Clients.Add(Client);
                _context.SaveChanges();
                return Client;

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



                var res = _context.Clients.FirstOrDefault(r => r.ID.Equals(id));
                
                res.Deleted = true;
                if (res != null)
                {
                    _context.Clients.Update(res);
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

        public Client Update(Client Client)
        {

            try
            {
                _context.Update(Client);
                _context.SaveChanges();
                return Client;
            }
            catch (Exception ex)
            {
                throw ex;

            }
            
        }


        public bool CheckUnicCodification(string numero)
        {
                return _context.Clients.Where(s => s.Numero.Equals(numero)).Any();
           

            
        }
    }
}
