using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Contracts
{
    public interface IContactRepository
    {
        
            List<Contact> GetAll();
            Contact GetById(int id);
            //Contact GetByClient(int id);
            Contact Add(Contact contact);
            Contact Update(Contact contact);
            bool Delete(int id);

        
    }
}
