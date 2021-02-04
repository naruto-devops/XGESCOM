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
                res = _context.Clients.ToList();

            }
            catch (Exception)
            {
                res = null;
            }

            return res;
        }

        public Client GetById(int id)
        {
            try
            {
                var res = _context.Clients.FirstOrDefault(r => r.ID.Equals(id));
                return res;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Client Add(Client Client)
        {
            try
            {
                _context.Clients.Add(Client);
                _context.SaveChanges();

            }
            catch (Exception)
            {
                return null;
            }
            return Client;
        }

        public bool Delete(int id)
        {

            try
            {
                var res = _context.Clients.FirstOrDefault(r => r.ID.Equals(id));
                if (res != null)
                {
                    _context.Clients.Remove(res);
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

        public Client Update(Client Client)
        {

            try
            {
                _context.Update(Client);
                _context.SaveChanges();

            }
            catch (Exception)
            {
                return null;

            }
            return Client;
        }

    }
}
