using Dapper;
using Microsoft.Extensions.Configuration;
using Models.Data;
using Models.Models;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Repositories.Implementations
{
    public class ContactRepository : IContactRepository
    {

        XSoftContext _context;
        public ContactRepository(XSoftContext context)
        {
            _context = context;
        }

        public List<Contact> GetAll()
        {
            var res = new List<Contact>();
            try
            {
                res = _context.Contacts.ToList();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }

           
        }

        public Contact GetById(int id)
        {
            try
            {
                var res = _context.Contacts.FirstOrDefault(r => r.ID.Equals(id));
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Contact Add(Contact contact)
        {
            try
            {
                _context.Contacts.Add(contact);
                _context.SaveChanges();
                return contact;
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
                var res = _context.Contacts.FirstOrDefault(r => r.ID.Equals(id));
                if (res != null)
                {
                    _context.Contacts.Remove(res);
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

        public Contact Update(Contact contact)
        {

            try
            {
                _context.Update(contact);
                _context.SaveChanges();
                return contact;
            }
            catch (Exception ex)
            {
                throw ex;

            }
            
        }
    }
}
