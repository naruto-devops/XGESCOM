using Models.Models;
using Repositories.Contracts;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Implementations
{
   public  class ContactServices : IContactService
    {
        IContactRepository _ContactRepository;

        public ContactServices(IContactRepository contact)
        {
            _ContactRepository = contact;
        }

        public bool CheckContact_ExistClient(int id)
        {
            //var fat = _ContactRepository.GetByClient(id);
            //return fat != null;
            return true;
        }

        public List<Contact> GetAll()
        {
            List<Contact> result = new List<Contact>();
            result = _ContactRepository.GetAll();
            return result;
        }

        public Contact GetById(int id)
        {
            return _ContactRepository.GetById(id);
        }

        public Contact Add(Contact contact)
        {
            _ContactRepository.Add(contact);

            return contact;

        }

        public Contact Update(Contact contact)
        {
            _ContactRepository.Update(contact);
            return contact;
        }

        public bool Delete(int id)
        {
            return _ContactRepository.Delete(id);


        }
    }
}
