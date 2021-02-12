using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Contracts
{
   public  interface IContactService
    {
        List<Contact> GetAll();
        Contact GetById(int id);
       
        Contact Add(Contact contact);
        Contact Update(Contact contact);
        
        bool CheckContact_ExistClient(int id);
        bool Delete(int id);
    }
}
