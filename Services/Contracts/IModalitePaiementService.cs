using Models;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Contracts
{
   public  interface IModalitePaiementService
    {
        List<ModalitePaiement> GetAll();
        ModalitePaiement GetById(int id);
        ModalitePaiement Add(ModalitePaiement cbl);
        ModalitePaiement Update(ModalitePaiement cbl);

        Client CheckModalite_ExistClient(int id);
        bool Delete(int id);
    }
}
